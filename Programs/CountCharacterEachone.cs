using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject.Programs
{
    public class CountCharacterEachone
    {
        static void Main(string [] args)
        {
            CountCharacterEachone.Countcharacter("Saleema");
            Console.ReadLine();
        }
        public static void Countcharacter(string str)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!characterCount.ContainsKey(character))
                    {
                        characterCount.Add(character, 1);
                    }
                    else
                    {
                        characterCount[character]++;
                    }
                }

            }
            foreach (var character in characterCount)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);


            }
            Console.WriteLine("FindDuplecate in given string");
            foreach (var character in characterCount)
            {
                if (character.Value > 1)
                {
                    Console.WriteLine($"{character.Key} - {character.Value} times");
                }
            }
        }
    }
}
