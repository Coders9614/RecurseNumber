using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecurseNumber
{
    internal class Program
    {
        static void PrintNaturalNumbers(int n)
        {
            if (n > 0)
            {
               
                PrintNaturalNumbers(n - 1); // Recur for the previous number
                Console.Write($"{n} ");
            }
        }

        static void Main()
        {
            Console.Write("How many numbers to print: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Expected Output:");
            PrintNaturalNumbers(n);
            Console.WriteLine(); // Print a newline after the numbers
            Console.ReadKey();
        }
      
    }
}
