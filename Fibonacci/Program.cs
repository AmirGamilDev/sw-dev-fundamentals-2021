using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        private static long numberOfCalls = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of Fibonacci numbers you want:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Iterative:");
            DoFibonacciIterative(number);

            Console.WriteLine("");

            Console.WriteLine("Recursion:");
            DoFibonacciRecursive(number);

            Console.ReadLine();
        }

        private static void DoFibonacciIterative(int n)
        {
            string output = "";

            // write code for iterative calculation of Fibonacci **SEQUENCE** here
            // if a 5 is passed to this method, it will print 0, 1, 1, 2, 3

            long fNMinus2 = 0;
            long fNMinus1 = 1;

            for(long i = 0; i < n; i++)
            {
                long current;

                if(output.Length > 0)
                {
                    output += ", ";
                }

                if(i == 0 || i == 1)
                {
                    current = i;
                }
                else
                {
                    current = fNMinus1 + fNMinus2;

                    fNMinus2 = fNMinus1;
                    fNMinus1 = current;
                }

                output += current;
            }

            Console.WriteLine(output);
        }

        private static void DoFibonacciRecursive(int n)
        {
            string output = "";

            // write code for printing of Fibonacci **SEQUENCE** here
            // this method will use the CalculateFibonacciResursive method defined below
            // if a 5 is passed to this method, it will print 0, 1, 1, 2, 3

            for (int i = 0; i < n; i++)
            {
                if(output.Length > 0)
                {
                    output += ", ";
                }

                output += CalculateFibonacciResursive(i);
            }

            Console.WriteLine(output);
            Console.WriteLine($"\nNumber of calls: {numberOfCalls}");
        }

        private static long CalculateFibonacciResursive(long n)
        {
            numberOfCalls++;

            // write code for recursive calculation of Fibonacci **NUMBER** here
            // this method returns just ONE number - the nth value of the Fibonacci in the sequence
            // for example, if a 6 is passed to this method, it will return an 8

            if(n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return CalculateFibonacciResursive(n - 1) + CalculateFibonacciResursive(n - 2);
            }
        }
    }
}
