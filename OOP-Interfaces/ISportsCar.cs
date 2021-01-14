using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interfaces
{
    interface ISportsCar : ICar
    {
        public void Turbo()
        {
            Console.WriteLine("Turbo");
        }

        void ICar.StartEngine()
        {
            Console.WriteLine("*WHooosh*");
        }

        void ICar.Ride()
        {
            Console.WriteLine("Ride it..");
        }


    }
}
