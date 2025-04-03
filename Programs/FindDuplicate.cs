using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Programs
{
    public class FindDuplicate
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in inputString)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            Console.WriteLine("Duplicate characters:");
            foreach (var pair in charCount)
            {
                if (pair.Value > 1)
                    Console.WriteLine($"{pair.Key} - {pair.Value} times");
            }
        }
    }
}
