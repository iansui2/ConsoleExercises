using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double firstnumber, secondnumber, sum, difference, product, quotient, remainder;

                Console.WriteLine("Test Data: ");
                Console.WriteLine("Input the first number: ");
                firstnumber = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Input the second number: ");
                secondnumber = Convert.ToDouble(Console.ReadLine());

                sum = firstnumber + secondnumber;
                difference = firstnumber - secondnumber;
                product = firstnumber * secondnumber;
                quotient = firstnumber / secondnumber;
                remainder = firstnumber % secondnumber;

                Console.WriteLine("Expected Output: ");
                Console.WriteLine(firstnumber + " + " + secondnumber + " = " + sum);
                Console.WriteLine(firstnumber + " - " + secondnumber + " = " + difference);
                Console.WriteLine(firstnumber + " * " + secondnumber + " = " + product);
                Console.WriteLine(firstnumber + " / " + secondnumber + " = " + quotient);
                Console.WriteLine(firstnumber + " mod " + secondnumber + " = " + remainder);
            }
            catch(FormatException)
            {
                Console.WriteLine("Cannot convert string to double");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
