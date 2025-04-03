using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.AnonymousMethod
{
    public class AnonymousMethod
    {
        public delegate string GreetingsDelegate(string name);
        static void Main(string[] args)
        {
            GreetingsDelegate obj = (name) =>
            {
                return "Hello @" + name + " welcome to Dotnet Tutorials";
            };
            string GreetingsMessage = obj.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }





        ////Anonymous Method Accessing Variables Defined Outside
        //public delegate string GreetingsDelegate(string name);
        //static void Main(string[] args)
        //{
        //    string Message = "Welcome to Dotnet Tutorials";
        //    GreetingsDelegate gd = delegate (string name)
        //    {
        //        return "Hello @" + name + " " + Message;
        //    };
        //    string GreetingsMessage = gd.Invoke("Pranaya");
        //    Console.WriteLine(GreetingsMessage);
        //    Console.ReadKey();
        //}


        //Here, you need to understand two things.As we are using the Anonymous Method in C# for lesser writing,
        //then why do we need to use the delegate keyword?
        //And the second thing is as the delegate knows about the return type and input parameter type it accepts,
        //then why do we need to explicitly specify the parameter type the delegate accepts?
    }
}
