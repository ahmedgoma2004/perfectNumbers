using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here is the program explanation

            Console.WriteLine("Welcome to the perfect Number Printer!");
            Console.WriteLine("This program prints the perfect numbers between a given range.");
            Console.WriteLine("Please enter the starting and ending numbers of the range of perfect numbers you want to get.");
            Console.WriteLine("=============================================================================================");

            //Here receive values from the user

            Console.Write("Enter the starting number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the ending number: ");
            int n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
            {
                Console.WriteLine("Error: The starting number cannot be greater than the ending number.");
                return;
            }

            Console.WriteLine("These are the perfect numbers between " + n1 + " and " + n2 + " : ");

            //Nested loop

            for (int i = n1; i <= n2; i++)
            {
                int perfect = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        perfect += j;
                    }
                }
                if (perfect == i)
                {
                    Console.Write(i + " | ");
                }
            }
            Console.WriteLine();
        }
    }
}
