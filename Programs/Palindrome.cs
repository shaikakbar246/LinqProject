using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Programs
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
        public static void ChkPalindrome(string str)
        {
            bool flag = false;
            for (int i = 0, j = str.Length - 1; i < str.Length / 2; i++, j--)
            {
                if (str[i] != str[j])
                {
                    flag = false;
                    break;
                }
                else
                    flag = true;
            }
            if (flag)
            {
                Console.WriteLine("Palindrome");
            }
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}
