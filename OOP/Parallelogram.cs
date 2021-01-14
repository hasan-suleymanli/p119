using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Parallelogram : Quadrangular
    {
        public double Diagonal{ get; set; }
        public override double GetArea()
        {
            return A * B + C - Diagonal;
        }

        public double GetDiagonal()
        {
            return Diagonal;
        }

        public Parallelogram(double a, double b, double c, double d) : base(a,b,c,d)
        {

        }
    }
}
