using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Quadrangular
    {
        //public double A{ get; set; }
        //public double B { get; set; }
        //public double C { get; set; }
        //public double D { get; set; }

        public Sides Sides { get; set; }

        protected Quadrangular(double a, double b, double c, double d)
        {
            //A = a;
            //B = b;
            //C = c;
            //D = d;

            Sides = new Sides(a, b, c, d);
        }

        public  double GetPerimeter()
        {
            return Sides.A + Sides.B + Sides.C + Sides.D;
        }

        public abstract double GetArea();
    }
}
