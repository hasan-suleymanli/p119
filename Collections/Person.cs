using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Person
    {
        public int Age { get; set; }
        public int Salary { get; set; }

        public string Name { get; set; }

        public Person(int age, int salary, string name)
        {
            Age = age;
            Salary = salary;
            Name = name;
        }
    }
}
