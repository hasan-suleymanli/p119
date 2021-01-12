using System;

namespace Delegates
{
    class Program
    {
        //delegate void Message(int a, string n);
        //delegate int DoNumbers(int a, int b);
        //delegate bool Filter(int x);
        //delegate bool Action(int x);

        //Predicate - geriye bool qaytarir
        //Action - void
        //Func - return something

        static void Main(string[] args)
        {
            //Message msg = null;
            //Action<int, string> action = null;

            //if (DateTime.Now.Hour < 12)
            //{
            //    msg = GoodMorning;
            //} else
            //{
            //    msg = GoodEvening;
            //}

            //msg += GoodMorning;
            //msg += GoodEvening;

            //msg();
            //if (msg != null)
            //{
            //    msg();
            //}

            //msg?.Invoke();

            int[] numbers = { 43, 54, 76, 87, -1, 0, 4, -5 };

            Console.WriteLine("Is Even:");
            FilterNumbers(numbers, IsEven);
            Console.WriteLine();

            Console.WriteLine("Is MoreThanZero:");
            FilterNumbers(numbers, MoreThanZero);
            Console.WriteLine();

            Console.WriteLine("Is LessThanZero:");
            FilterNumbers(numbers, LessThanZero);

            //Lambda expressions
            //FilterNumbers(numbers, x => x % 2 == 0);
            //FilterNumbers(numbers, x => x > 0);
            //FilterNumbers(numbers, x => x < 0);

            //Anonym method
            //FilterNumbers(numbers, delegate (int x)
            //{
            //    return x > 0;
            //});

            //FilterNumbers(numbers, (x, y) => 
            //{
            //    return x % 2 == 0;
            //});

            int sum = NumbersOperation(10, 20, (a, b) => a + b);
            int divide = NumbersOperation(10, 20, (a, b) => a / b);
            NumbersOperation(10, 20, (a, b) => 
            {
                a += 10;
                b -= 10;
                return a + b;
            });

        }

        private static int NumbersOperation(int x, int y, Func<int, int, int> func)
        {
            return func(x, y);
        }

        private static void FilterNumbers(int[] numbers, Predicate<int> filter)
        {
            foreach(int number in numbers)
            {
                if (filter(number))
                {
                    Console.WriteLine($"True! Number: {number}");
                }
            }
        }

        //private static void FilterNumbersIsEven(int[] numbers)
        //{
        //    foreach (int number in numbers)
        //    {
        //        if (number % 2 == 0)
        //        {
        //            Console.WriteLine($"True! Number: {number}");
        //        }
        //    }
        //}

        //private static void FilterNumbersMoreThanZero(int[] numbers)
        //{
        //    foreach (int number in numbers)
        //    {
        //        if (number > 0)
        //        {
        //            Console.WriteLine($"True! Number: {number}");
        //        }
        //    }
        //}

        private static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        private static bool MoreThanZero(int x)
        {
            return x > 0;
        }

        private static bool LessThanZero(int x)
        {
            return x < 0;
        }

        //private static void GoodMorning()
        //{
        //    Console.WriteLine("Good Morning!");
        //}

        //private static void GoodEvening()
        //{
        //    Console.WriteLine("Good Evening!");
        //}


    }
}
