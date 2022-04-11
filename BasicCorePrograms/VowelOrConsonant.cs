using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class VowelOrConsonant
    {
        public void VowelConsonant()
        {
            char ch;
            Console.Write("Enter an Alphabet to check vowel or consonant :");
            ch = Console.ReadKey().KeyChar;
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine("\n{0} is an Alphabet", ch);
            }
            else
            {
                Console.WriteLine("\n{0} is a Consonant", ch);
            }


        }
    }
}
