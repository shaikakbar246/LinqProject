using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.GenericDelegates
{
    public class GenericDelegates
    {

        public  double AddNumber1(int no1,float no2,double no3)
        {
            return no1 + no2 + no3;
        }
        public  void AddNumber2(int no1, float no2, double no3)
        {
            Console.WriteLine(no1 + no2 + no3);
        }
        public  bool AddNumber3(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Generic Delegates");
            GenericDelegates obj4 = new GenericDelegates();
            Func<int, float, double, double> obj1 = new Func<int, float, double, double>(obj4.AddNumber1);
            double Rsult = obj1.Invoke(1999, 4, 6);
            Console.WriteLine(Rsult);

            Action<int, float, double> obj2 = new Action<int, float, double>(obj4.AddNumber2);
            obj2.Invoke(2, 4, 6);

            Predicate<string> obj3 = new Predicate<string>(obj4.AddNumber3);
            bool status = obj3.Invoke("Akbar");
            Console.WriteLine(status);
            Console.Read();
        }
    }
}
