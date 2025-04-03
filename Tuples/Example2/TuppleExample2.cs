using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Tuples.Example2
{
    public class TuppleExample2
    {
        static void Main()
        {
            //De-Constructing Tuples 
            (string Name, double Salary, string Gender, string Dept) = GetEmployeeDetails(1001);
            //Do something with the data.
            //Here we are just printing the data in the console
            Console.WriteLine("Employee Details :");
            Console.WriteLine($"Name: {Name},  Gender: {Gender}, Department: {Dept}, Salary:{Salary}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        //GetEmployeeDetails Method returns a tuple with 4 values
        private static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
        {
            //Based on the EmployyeID get the data from a database
            //Here we are hardcoded the value
            string EmployeeName = "Pranaya";
            double Salary = 2000;
            string Gender = "Male";
            string Department = "IT";
            //Returning 4 Values through a Tuple
            return (EmployeeName, Salary, Gender, Department);
        }
    }
}
