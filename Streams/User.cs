using System;
using System.Collections.Generic;
using System.Text;

namespace Streams
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
        public int Account{ get; set; }

        [NonSerialized]
        public string Info;

        public User(string name, int age, int account)
        {
            Name = name;
            Age = age;
            Account = account;
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
