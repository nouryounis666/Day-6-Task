﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Task
{
    public class Point
    {
        public int X;
        public int Y;

        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public Point(int x)
        {
            X = x;
            Y = 0;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";

        }

        public string ToCustomString()
        {
            return $"Point: [X={X}, Y={Y}]";
        }
    }
}