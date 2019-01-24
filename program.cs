using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user to type in a number
            {
                int i, number, fact;
                Console.WriteLine("\nPlease enter a number and press enter");
                number = int.Parse(Console.ReadLine());
                fact = number;

                // Calculate factorial
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }

                // Display the factorial to the user
                Console.WriteLine("\nThe factorial of this number is " + fact);
                Console.WriteLine("\nWhen finished, press enter to close console");
                Console.ReadLine();
            }           
        }
    }
}
