using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Tuples.Example1
{
    public class TupleExample1
    {
        private  (int count,double sum) Calculate(IEnumerable<double> values)
        {
            Console.WriteLine("Example one of  tuples");

            int count = 0;
            double sum = 0;
            foreach (var value in values) {
                count++;
                sum += value;
            }
            return (count,sum);
        }

        static void Main(string[] args)
        {
            var values = new List<double> { 10, 20, 30, 40, 50 };
            TupleExample1 obj1=new TupleExample1();
            var (cungt,sum)= obj1.Calculate(values);
            Console.WriteLine($"there are {cungt} values and their sum is {sum}");
            Console.ReadKey();
        }
    }
}
