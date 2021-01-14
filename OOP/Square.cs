using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square : Quadrangular
    {
        public override double GetArea()
        {
            return Math.Pow(Sides.A, 2);
        }

        public Square(double a) : base(a,a,a,a)
        {

        }
    }
}
