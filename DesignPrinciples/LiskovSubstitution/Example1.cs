using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.DesignPrinciples.LiskovSubstitution
{
    public class Example1
    {
        ////with out Liskov Substitution Principle
        //static void Main(string[] args)
        //{

        //    Apple apple = new Orange();
        //    Console.WriteLine(apple.GetColor());
        //    Console.ReadLine();
        //}
        //public class Apple
        //{
        //    public virtual string GetColor()
        //    {
        //        return "Red";
        //    }
        //}
        //public class Orange : Apple
        //{
        //    public override string GetColor()
        //    {
        //        return "Orange";
        //    }
        //}
        //with Liskov Substitution Principle using Interface
        static void Main(string[] args)
        {
            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.ReadKey();
        }

        public interface IFruit
        {
            string GetColor();
        }
        public class Apple : IFruit
        {
            public string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : IFruit
        {
            public string GetColor()
            {
                return "Orange";
            }
        }
        ////with Liskov Substitution Principle using Abstarct
        //static void Main(string[] args)
        //{
        //    FruitAbstract fruit = new Orange();
        //    Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
        //    fruit = new Apple();
        //    Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
        //    Console.ReadKey();
        //}
        //public abstract class FruitAbstract
        //{
        //    public void Hello()
        //    {
        //        Console.WriteLine("Hello Akbar");
        //    }
        //    public abstract string GetColor();
        //}
        //public class Apple : FruitAbstract
        //{
        //    public override string GetColor()
        //    {
        //        return "Red";
        //    }
        //}
        //public class Orange : FruitAbstract
        //{
        //    public override string GetColor()
        //    {
        //        return "Orange";
        //    }
        //}
    }
}
