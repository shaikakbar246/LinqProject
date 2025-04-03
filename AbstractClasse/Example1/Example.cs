using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.AbstractClasse.Example1
{
    public class Example
    {
        static void Main(string[] args)
        {
            Example1.Method1();
            //Compile Time Error: Cannot create an instance of the abstract class or interface 'Example'
            //Example e = new Example1();
            ////Not possible
            //e.Method2();
            Console.ReadKey();
        }
    }
    public abstract class Example1
    {
        public static void Method1()
        {
            Console.WriteLine("Example Method1 method");
        }
        public void Method2()
        {
            Console.WriteLine("Example Method2 method");
        }
    }
}
