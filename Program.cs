﻿using System;

namespace GeometryTasks
{
    public class Vector
    {
        public double X;
        public double Y;
    }
    public class Geometry
    {
        public static double GetLength(Vector vector)
        {
            var vectorLength = Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
            return vectorLength;
        }

        public static Vector Add(Vector x, Vector y)
        {
            var dV = new Vector();
            dV.X = x.X+y.X;
            dV.Y = x.Y+y.Y;//изменил формулу
            return dV;
        }
    }
}
namespace vector1
{
    class Program
    {
        static void Main(string[] args)
        {
            //заккомментил потомучто не работает
            // add some comment
            //Console.WriteLine(GeometryTasks.Geometry.GetLength());
            //Console.WriteLine(GeometryTasks.Geometry.Add(10, 20));

        }
    }
}
