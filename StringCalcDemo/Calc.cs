using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringCalcDemo
{
    public class Calc
    {
        public int Add(string numbers)
        {
            if (numbers == string.Empty)
            {
                return 0;
            }

            var digits = Regex.Split(numbers, @"(?!(-))\D+(?<!(-))");


            var numList = digits
                .Select(n => Convert.ToInt32(n))
                .Where(n => n <= 1000);


            if (numList.Any(n => n < 0))
            {
                string message = numList.Where(n => n < 0)
                                .Aggregate("", (prev, curr) => prev == "" ? curr.ToString() : prev + "," + curr);

                throw new Exception(String.Format("You entered {0}.Negatives are not allowed", message));
            }

            return numList.Sum();
        }

    }
}
