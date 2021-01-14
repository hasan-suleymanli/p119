using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Animal
    {
        //1. Has default logic, can't be overriden
        //2. Has default logic, can be overriden
        //3. Has not default logic, must be overriden

        //1-ci tip
        public bool HasBrain()
        {
            Console.WriteLine("Different codes....");
            return true;
        }

        public Animal()
        {

        }

        //2-ci tip
        public virtual void Walk()
        {
            Console.WriteLine("walking...");
        }

        //3-cu tip
        public abstract void Eat();

    }

    class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cat eating...");
        }

        //public override bool HasBrain()
        //{

        //}
        public override void Walk()
        {
            Console.WriteLine("Catish walk..");
            base.Walk();
        }
    }
}
