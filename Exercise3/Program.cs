using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            double firstnumber;
            double secondnumber;
            double thirdnumber;
            double fourthnumber;
            double average;

            Console.WriteLine("Test Data: ");
            Console.WriteLine("Enter the first number: ");
            firstnumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            secondnumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the third number: ");
            thirdnumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the fourth number: ");
            fourthnumber = Convert.ToDouble(Console.ReadLine());

            average = (firstnumber + secondnumber + thirdnumber + fourthnumber) / 4;

            Console.WriteLine("\n");
            Console.WriteLine("Expected Output: ");
            Console.WriteLine("The average of " + firstnumber + " , " + secondnumber + " , " + thirdnumber + " , " + fourthnumber + " is: " + average);

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
