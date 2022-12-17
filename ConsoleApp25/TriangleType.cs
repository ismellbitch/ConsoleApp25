using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class TriangleType
    {
        private double a;
        private double b;
        private double c;

        public TriangleType(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double A 
        {
            get { return a; }
            set { if (a > 0) a = value; }
        }
        public double B
        {
            get { return b; }
            set { if (b > 0) b = value; }
        }
        public double C
        {
            get { return c; }
            set { if (c > 0) c = value; }
        }

        public string GetTriangleTyple()
        {
            if (A == B && A == C) return "Треугольник равносторонний";
            else if (A == Math.Sqrt(B * B + C * C) || B == Math.Sqrt(A * A + C * C) || C == Math.Sqrt(A * A + B * B)) return "Треугольник прямоугольный";
            else return "Треугольник простой";
        }
    }
}
