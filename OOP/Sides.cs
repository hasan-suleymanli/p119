using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    struct Sides
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }

        public Sides(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
    }
}
