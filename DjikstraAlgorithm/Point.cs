using System;
using System.Collections.Generic;
using System.Text;

namespace DjikstraAlgorithm
{
    class Point
    {
        public int DistanceFromStart;
        public bool IsChecked;

        public string Name;

        public List<Point> Neighbours = new List<Point>();

        public Point(int number)
        {
            DistanceFromStart = 99999;
            IsChecked = false;

            Name = number.ToString();
        }
    }
}
