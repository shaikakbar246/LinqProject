using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Programs
{
    public class Factorial
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factorial of a given number");
            int number = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }

            Console.WriteLine($"Factorial of {number} is :{factorial}");
            Console.ReadLine();
        }

       


        

        
    }
}
