using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class Vowel
    {
        public void Core()
        { 

        Console.WriteLine("Enter a letter to check whether it is vowel");
            char n = Convert.ToChar(Console.ReadLine());
        n = char.ToUpper(n);
            if (n == 'A' || n == 'E' || n == 'I' || n == 'O' || n == 'U')
            {
                Console.WriteLine($"The letter {n} is a vowel");
            }
            else
            {
                Console.WriteLine($"The letter {n} is a consonant");
            }
        }
    }
}
