using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interfaces
{
    class Mercedes : ICar
    {
        public string CarName { get; set; }

        public void Ride()
        {
            Console.WriteLine("Merci-style riding..");
        }

        void ICar.StartEngine()
        {
            Console.WriteLine("*SILENT*");
        }

    }
}
