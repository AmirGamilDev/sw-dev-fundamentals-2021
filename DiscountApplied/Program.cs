using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountApplied
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter quantity:");
            int quantity = int.Parse(Console.ReadLine());

            int discountPercentage = CalculateDiscountPercentage(quantity);

            Console.WriteLine($"Discount percentage for {quantity} items: {discountPercentage}%");
            Console.ReadLine();
        }

        public static int CalculateDiscountPercentage(int quantity)
        {
            if(quantity < 10)
            {
                return 5;
            }
            else if(quantity < 50)
            {
                return 10;
            }
            else if(quantity < 100)
            {
                return 15;
            }
            else
            {
                return 20;
            }
        }
    }
}
