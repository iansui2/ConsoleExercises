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
            start:
            int digit;
            Console.WriteLine("Test Data: ");
            Console.WriteLine("Enter a digit: ");
            digit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Expected Output: ");

            Console.Write( digit );
            Console.Write(" ");
            Console.Write( digit );
            Console.Write(" ");
            Console.Write( digit );
            Console.Write(" ");
            Console.Write( digit );
            Console.WriteLine();

            Console.Write( digit );
            Console.Write( digit );
            Console.Write( digit );
            Console.WriteLine( digit );

            Console.WriteLine("{0} {0} {0} {0}", digit);

            Console.WriteLine("{0}{0}{0}{0}", digit);

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
