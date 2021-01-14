using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interfaces
{
    class Lamborghini : ISportsCar, ILuxuryCars
    {
        public string CarName { get; set; }

        public void Wow()
        {
            Console.WriteLine("WOW!");
        }
    }
}
