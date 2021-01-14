using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Rectangular : Quadrangular
    {
        public override double GetArea()
        {
            return Sides.A * Sides.B;
        }

        public Rectangular(double a, double b, double c, double d) : base(a,b,c,d)
        {

        }
    }
}
