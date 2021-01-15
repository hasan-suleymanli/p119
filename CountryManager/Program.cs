using System;
using System.Collections.Generic;

namespace CountryManager
{
    class Program
    {
        public static Dictionary<string, string> dictionary = new Dictionary<string, string>()
        {
            { "Burundi", "Bujumbura" }
        };
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Write country: ");
                string country = Console.ReadLine();

                Console.WriteLine("Write capital: ");
                string capital = Console.ReadLine();

                dictionary.Add(country, capital);
            }

            MakeASearch();
        }

        public static void MakeASearch()
        {
            Console.WriteLine("Which country do you search?");
            string searchCountry = Console.ReadLine();

            //string capital = dictionary[searchCountry];
            //dictionary.TryGetValue(searchCountry, out string capital);
            //if (capital == null)
            //{
            //    Console.WriteLine("there is no country");
            //} else
            //{
            //    Console.WriteLine(capital);
            //}

            //searchCountry == dictionary.Values.ToString()
            if(searchCountry == "all")
            {
                foreach(var x in dictionary)
                {
                    Console.WriteLine($"Country: {x.Key}");
                    Console.WriteLine($"Capital: {x.Value}");
                }

                //foreach (var x in dictionary.Values)
                //{
                //    Console.WriteLine($"Capital: {x}");
                //}

                //foreach (var x in dictionary.Keys)
                //{
                //    Console.WriteLine($"Country: {x}");
                //}
            }
            else
            {
                dictionary.TryGetValue(searchCountry, out string? searchCapital);
                Console.WriteLine(searchCapital ?? "There is no such country");
                //string searchCapital = dictionary[searchCountry];
            }

            Console.WriteLine("Wanna search again?");
            string response = Console.ReadLine();

            if (response == "y")
                MakeASearch();
        }
    }
}
