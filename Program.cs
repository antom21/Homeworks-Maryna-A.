using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt_3
{
    class Program
    {
        static void Main()
        {
            int x, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (x = number - 1; x >= 1; x--)
            {
                fact = fact * x;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();

        }
    }
}
