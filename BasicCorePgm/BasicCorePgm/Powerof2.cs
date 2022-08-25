using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class Powerof2
    {
        public void Core(int n)

        {
            int limit = 31, num = 0;
            if (n <= limit)
            {
                while (num <= n)
                {
                    double power = Math.Pow(2, num);
                    Console.WriteLine(power);
                    num++;
                }
            }
            else
            {
                Console.WriteLine($"Invalid input, limit is {limit}");
            }
        }
    }
}

