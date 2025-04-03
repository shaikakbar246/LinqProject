using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Programs
{
    public  class RevverseString
    {
        static void Main(string[] args)
        {
            RevverseString.ReverseStringMethod("Akbar");
            Console.ReadLine();
        }

        public static void ReverseStringMethod(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                charArray[i] = str[j];
                charArray[j] = str[i];
            }
            string reversedstring = new string(charArray);
            Console.WriteLine(reversedstring);
        }
    }
}
