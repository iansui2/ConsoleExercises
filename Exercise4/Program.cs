using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            double x;
            double y;
            double z;
            double result1;
            double result2;

            Console.WriteLine("Test Data: ");
            Console.WriteLine("Enter first number - ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number - ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number - ");
            z = Convert.ToDouble(Console.ReadLine());

            result1 = (x + y) * z;
            result2 = x * y + y * z;

            Console.WriteLine("Expected Output: ");
            Console.WriteLine("Result of specified numbers " + x + ", " + y + " and " + z + ", " + "(x + y).z is " + result1 + " and x.y + y.z is " + result2);

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
