using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqProject.Indexer.Example1
{
    public class IndexerExample1
    {
        // Like Virtual Array
        //Modifiers: The Modifiers are nothing but the access specifiers such as public, private, protected, internal, etc.
        // Type: In our class, as we are dealing with the integer(ID), string (Name, Job, Department, Location, and Gender), and double (Salary) type of values.So, here we need to use the type as an Object because the Object type can return any type of values.
        //This: This keyword tells that we are defining an indexer on the current class, in this case, the current class is Employee.
        //Int index or String name: The int index or string name is used to specify whether you want to access the values by using its integer index position or by using the string name.
        //Get and Set: The get accessor is used for returning the value and the set accessor is used for assigning the value.

        public class Employee
        {
            //Declare the Properties
            public int ID { get; set; }
            public string Name { get; set; }
            public string Job { get; set; }
            public double Salary { get; set; }
            public string Location { get; set; }
            public string Department { get; set; }
            public string Gender { get; set; }
            //Initialize the Properties through Constructor
            public Employee(int ID, string Name, string Job, int Salary, string Location,
                            string Department, string Gender)
            {
                this.ID = ID;
                this.Name = Name;
                this.Job = Job;
                this.Salary = Salary;
                this.Location = Location;
                this.Department = Department;
                this.Gender = Gender;
            }
            //Creating the Indexer using Integer Index Position
            public object this[int index]
            {
                //Get accessor is used for returning a value
                get
                {
                    //based in the index position, return the appropriate property value
                    if (index == 0)
                        return ID;
                    else if (index == 1)
                        return Name;
                    else if (index == 2)
                        return Job;
                    else if (index == 3)
                        return Salary;
                    else if (index == 4)
                        return Location;
                    else if (index == 5)
                        return Department;
                    else if (index == 6)
                        return Gender;
                    else
                        return null;
                }
                //Set accessor is used to assigning a value
                set
                {
                    //based in the index position, set the appropriate property value
                    if (index == 0)
                        ID = Convert.ToInt32(value);
                    else if (index == 1)
                        Name = value.ToString();
                    else if (index == 2)
                        Job = value.ToString();
                    else if (index == 3)
                        Salary = Convert.ToDouble(value);
                    else if (index == 4)
                        Location = value.ToString();
                    else if (index == 5)
                        Department = value.ToString();
                    else if (index == 6)
                        Gender = value.ToString();
                }
            }
        }
        static void Main(string[] args)
        {
            //Create an Instance of the Employee Class
            Employee emp = new Employee(101, "Pranaya", "SSE", 10000, "Mumbai", "IT", "Male");
            //Access the Employee Object using Indexer i.e. using Integer Index Position
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Location = " + emp[4]);
            Console.WriteLine("Department = " + emp[5]);
            Console.WriteLine("Gender = " + emp[6]);
            //Set the Employee Object using Indexer i.e. using Integer Index Position
            emp[1] = "Kumar";
            emp[3] = 65000;
            emp[5] = "BBSR";
            Console.WriteLine("========After Modification========");
            //Access the Employee Object using Indexer i.e. using Integer Index Position
            Console.WriteLine("EID = " + emp[0]);
            Console.WriteLine("Name = " + emp[1]);
            Console.WriteLine("Job = " + emp[2]);
            Console.WriteLine("Salary = " + emp[3]);
            Console.WriteLine("Location = " + emp[4]);
            Console.WriteLine("Department = " + emp[5]);
            Console.WriteLine("Gender = " + emp[6]);
            Console.ReadLine();
        }

    }
}

 
