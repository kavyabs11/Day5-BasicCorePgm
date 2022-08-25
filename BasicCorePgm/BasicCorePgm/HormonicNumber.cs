using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class HormonicNumber
    {
        public void Core(int n)

        {

            double harm = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    harm = harm + (1.0 / i);
                    if (i == n)
                    {
                        Console.Write($"1/{i}");
                        break;
                    }
                    Console.Write($"1/{i}+");
                }
                Console.WriteLine($"\nThe value of {n}th harmonic number is {harm}");
            }
            else
            {
                Console.WriteLine("Invalid input, n shouldn't be negative");
            }
        }
    }
}
