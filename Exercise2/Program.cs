using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int number;

                Console.WriteLine("Test Data:");
                Console.WriteLine("Enter the number: ");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Expected Output: ");
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("Cannot convert string to integer");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
