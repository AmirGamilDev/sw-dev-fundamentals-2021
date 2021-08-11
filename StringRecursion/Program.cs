using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter word or phrase");
            string s = Console.ReadLine();

            Console.WriteLine("\nIterative\nOutput:");
            DoIterativeStringEcho(s);

            Console.WriteLine("\nRecursive\nOutput:");
            DoRecursiveStringEcho(s);
        }

        private static void DoIterativeStringEcho(string s)
        {
            for(int i = s.Length; i > 0; i--)
            {
                Console.WriteLine(s.Substring(0, i));
            }
        }

        private static void DoRecursiveStringEcho(string s)
        {
            Console.WriteLine(s);

            if (s.Length == 1)
            {
                return;
            }
            else
            {
                string substring = s.Substring(0, s.Length - 1);
                DoRecursiveStringEcho(substring);
            }
        }
    }
}
