using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialFromFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the value for n: ");
            int n = int.Parse(Console.ReadLine());

            int fact = CalculateFactorial(n);

            Console.WriteLine($"Factorial of {n} is {fact}");

            Console.ReadLine();
        }

        public static int CalculateFactorial(int n)
        {
            int fact = 1;

            while(n > 1)
            {
                fact *= n;  // same as fact = fact * n
                n--;
            }

            return fact;
        }
    }
}
