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
            start:
            int number;
            int firstresult;
            int secondresult;
            int thirdresult;
            int fourthresult;
            int fifthresult;
            int sixthresult;
            int seventhresult;
            int eightresult;
            int ninthresult;
            int tenthresult;
            int eleventhresult;

            Console.WriteLine("Test Data:");
            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());

            firstresult = number * 0;
            secondresult = number * 1;
            thirdresult = number * 2;
            fourthresult = number * 3;
            fifthresult = number * 4;
            sixthresult = number * 5;
            seventhresult = number * 6;
            eightresult = number * 7;
            ninthresult = number * 8;
            tenthresult = number * 9;
            eleventhresult = number * 10;

            Console.WriteLine("Expected Output:");
            Console.WriteLine(number + " * 0 = " + firstresult);
            Console.WriteLine(number + " * 1 = " + secondresult);
            Console.WriteLine(number + " * 2 = " + thirdresult);
            Console.WriteLine(number + " * 3 = " + fourthresult);
            Console.WriteLine(number + " * 4 = " + fifthresult);
            Console.WriteLine(number + " * 5 = " + sixthresult);
            Console.WriteLine(number + " * 6 = " + seventhresult);
            Console.WriteLine(number + " * 7 = " + eightresult);
            Console.WriteLine(number + " * 8 = " + ninthresult);
            Console.WriteLine(number + " * 9 = " + tenthresult);
            Console.WriteLine(number + " * 10 = " + eleventhresult);

            Console.ReadKey();
            Console.Clear();
            goto start;
        }
    }
}
