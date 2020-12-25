using System;
using System.Collections.Generic;
using System.Text;

namespace DjikstraAlgorithm
{
    class Edge
    {
        public Point StartPoint;
        public Point EndPoint;

        public int Weight;

        public Edge(Point startPoint, Point endPoint, int weight)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Weight = weight;
        }
    }
}
