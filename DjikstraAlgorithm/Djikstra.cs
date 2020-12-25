using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DjikstraAlgorithm
{
    class Djikstra
    {
        public Graph Graph;
        private List<Point> uncheckedPoints;
        public Point startPoint;

        public void FindShortestPaths()
        {
            startPoint.DistanceFromStart = 0;
            
            CheckPointNeighbours(startPoint);
            while (true)
            {
                var currentPoint = GetNextUncheckedPoint();

                if (currentPoint != null)
                {
                    CheckPointNeighbours(currentPoint);
                }
                else
                {
                    break;
                }
            }
        }

        private void CheckPointNeighbours(Point point)
        {
            foreach (Point neighbour in point.Neighbours)
            {
                var edge = FindEdgeWithTwoPoints(point, neighbour);

                if (neighbour.DistanceFromStart == 99999 || neighbour.DistanceFromStart > point.DistanceFromStart + edge.Weight)
                {
                    neighbour.DistanceFromStart = point.DistanceFromStart + edge.Weight;
                }
            }

            point.IsChecked = true;
            uncheckedPoints.Remove(point);
        }

        private Edge FindEdgeWithTwoPoints(Point pointA, Point pointB)
        {
            foreach (Edge edge in Graph.Edges)
            {
                if ((edge.StartPoint == pointA && edge.EndPoint == pointB) ||
                    (edge.StartPoint == pointB && edge.EndPoint == pointA))
                {
                    return edge;
                }
            }
            
            return null;
        }

        private Point GetNextUncheckedPoint()
        {
            if (uncheckedPoints.Count != 0)
            {
                return uncheckedPoints[0];
            }
            
            return null;
        }

        public Djikstra(int startPoint)
        {
            Graph = new Graph();
            
            Point[] uncheckedPointsArr = new Point[Graph.Points.Count];
            Graph.Points.CopyTo(uncheckedPointsArr);
            uncheckedPoints = uncheckedPointsArr.ToList<Point>();

            this.startPoint = Graph.Points[startPoint];

            FindShortestPaths();
        }
    }
}
