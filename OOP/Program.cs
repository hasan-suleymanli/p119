using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangular rectangular = new Rectangular(10,20,5,4);

            Square square = new Square(10);

            Console.WriteLine(rectangular.GetPerimeter());
        }
    }
}
