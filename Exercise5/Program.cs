using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int digit;

                Console.WriteLine("Test Data: ");
                Console.WriteLine("Enter a digit: ");
                digit = Convert.ToInt32(Console.ReadLine());

                string spaces = ($"{digit} {digit} {digit} {digit}");
                string noSpaces = ($"{digit}{digit}{digit}{digit}");

                Console.WriteLine("Expected Output: ");
                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine(spaces);
                    Console.WriteLine(noSpaces);
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
