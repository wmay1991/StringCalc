using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNumbers();
        }

        static void GetNumbers()
        {
            Console.WriteLine("Please enter a number");
            string numbers = Console.ReadLine();

            var calc = new Calc();
            calc.Add(numbers);
        }
    }
}
