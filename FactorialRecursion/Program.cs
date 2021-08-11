using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number for factorial calculation");
            int n = int.Parse(Console.ReadLine());

            int answer = CalculateFactorial(n);

            Console.WriteLine($"{n}! = {answer}");
            
            Console.ReadLine();
        }

        private static int CalculateFactorial(int number)
        {
            if(number == 0)
            {
                return 1;
            }
            else
            {
                int answer = number * CalculateFactorial(number - 1);

                return answer;
            }
        }
    }
}
