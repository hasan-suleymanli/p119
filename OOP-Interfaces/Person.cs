using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Interfaces
{
    public class Person
    {
        
        protected string name;
        private DateTime dob;
        //private int age;

        public static string Species = "Homo Sapiens";
        public const string Genre  = "Hominid";
        public readonly string Sex = "Male";
        public static readonly bool HasBrain = true;
        
        static Person()
        {
            HasBrain = false;
        }

        public Person(string name)
        {
            this.name = name;
            Age = 5;
            Sex = "Female";
        }
        
        public int Age {  private get; set; }

        //public string Name { 

        //    get
        //    {
        //        return "Mr." + name;
        //    }

        //    set
        //    {
        //        if(Age > 18)
        //        {
        //            name = value;
        //        }
        //    }

        // }

        //public byte DOB
        //{
        //    get
        //    {
        //        return (byte) (DateTime.Now.Year - dob.Year);
        //    }

        //    set
        //    {

        //    }
        //}



    }

    public class Employee : Person
    {
        public Employee(string name) : base(name)
        {
            base.name = "f";
        }
    }
}
