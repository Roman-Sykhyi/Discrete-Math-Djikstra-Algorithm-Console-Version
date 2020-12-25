using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DjikstraAlgorithm
{
    class Graph
    {
        public int[,] graphMatrix = new int[6,6]
        {
            { 0, 5, 0, 0, 0, 1},
            { 5, 0, 5, 5, 0, 0},
            { 0, 5, 0, 0, 6, 0},
            { 0, 5, 0, 0, 5, 7},
            { 0, 0, 6, 5, 0, 4},
            { 1, 0, 0, 7, 4, 0}
        };

        public List<Point> Points = new List<Point>();
        public List<Edge> Edges = new List<Edge>();

        public void BuildGraphFromMatrix()
        {
            for (int i = 0; i < 6; i++)
            {
                Points.Add(new Point(i+1));
            }
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = i; j < 6; j++)
                {
                    if (graphMatrix[i, j] != 0)
                    {
                        Edges.Add(new Edge(Points[i], Points[j], graphMatrix[i,j]));
                    }
                }
            }
        }

        public void FindNeighboursForPoints()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (graphMatrix[i, j] != 0)
                    {
                        Points[i].Neighbours.Add(Points[j]);
                    }
                }
            }
        }

        public Graph()
        {
            BuildGraphFromMatrix();
            FindNeighboursForPoints();
        }
    }
}
