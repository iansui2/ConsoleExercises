using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            double firstnumber;
            double secondnumber;
            double sum;
            double difference;
            double product;
            double quotient;
            double remainder;

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

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
        
    }
}
