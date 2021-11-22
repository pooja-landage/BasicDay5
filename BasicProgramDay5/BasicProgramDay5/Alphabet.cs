using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class Alphabet
    {
        public void Vowel()
        {
            char letter;
            Console.WriteLine("Problem:Check alphabet is Vowel or Consonant");
            Console.WriteLine("Enter alphabet");
            letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                Console.WriteLine("Alphabet is Vowel");
            else
                Console.WriteLine("Alphabet is Consonant");
        }
    }
}
