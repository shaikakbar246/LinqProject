using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static LinqProject.Indexer.Example1.IndexerExample1;

namespace LinqProject.OptionalParameter.OPExample1
{
    public  class OPExample1
    {
        static void Main(string[] args)
        {
            ADDNumbers(10, 20);
            ADDNumbers(10, 20, new object[] { 30, 40, 50 });
            ADDNumbers(10, 20, new int[] { 30, 40, 50 });
            ADDNumbers(10, 20,30, new int[] { 30, 40, 50 });
            ADDNumbers(10, 20, new int[] { 30, 40, 50 });
            Console.ReadLine();
        }
        public static void ADDNumbers(int FN, int SN)
        {
            int result = FN + SN;
            Console.WriteLine("Total = " + result.ToString());
        }
        public static void ADDNumbers(int FN, int SN, params object[] restOfTheNumbers)
        {
            Console.WriteLine("Parameter Array to Make Optional Parameter");
            int result = FN + SN;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
            Console.WriteLine("Total = " + result.ToString());
        }
        public static void ADDNumbers(int FN, int SN, int[] restOfTheNumbers)
        {
            int result = FN + SN;
            foreach (int i in restOfTheNumbers)
            {
                result += i;
            }
            Console.WriteLine("Total = " + result.ToString());
        }
       

        public static void ADDNumbers(int FN, int SN, int NZ,int[] restOfTheNumbers = null)
        {
            Console.WriteLine("Method Parameters Optional by Specifying Parameter Defaults");
            int result = FN + SN + NZ;
            //Loop through the restOfTheNumbers only if it is not null
            //else we will get runtime error
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }
        public static void ADDNumbers(int FN, int SN, int SZ, int NZ, [Optional] int[] restOfTheNumbers)
        {
            Console.WriteLine("Make Parameter Optional Using OptionalAttribute");
            int result = FN + SN + SZ + NZ;
            // loop thru restOfTheNumbers only if it is not null otherwise 
            // you will get a null reference exception
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }
            Console.WriteLine("Total = " + result.ToString());
        }

        
    }

}
