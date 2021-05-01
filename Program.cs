using System;
using System.Collections.Generic;

namespace AllMediaDesk
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter math formula");
            var input = Console.ReadLine();
            var calculator = new RegexCalculator.RegexCalculator();
            var result = calculator.Calculate(input);
            Console.WriteLine("The answer is: " + result);
            Console.WriteLine();
        }
    }
}
