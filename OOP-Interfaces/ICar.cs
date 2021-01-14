using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interfaces
{
    interface ICar
    {
        //Class can implements multiple interfaces, but only single base class
        //Interface can't have constructors
        //Interface can't fields
        
        public string CarName { get; set; }

        //1. Has default logic, can't be overriden
        //2. Has default logic, can be overriden
        //3. Has not default logic, must be overriden

        //1-ci tip
        sealed void FuelAlert()
        {
            Console.WriteLine("THERE IS NO FUEL!");
        }

        //2-ci tip
        void StartEngine()
        {
            //Console.WriteLine("Hrrrr");
            Console.WriteLine("Trumppapapap");
        }

        //3-cu tip
        public void Ride();
    }
}
