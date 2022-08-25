using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class EvenOdd
    {
        public void Core()
         {
            Console.WriteLine("Enter a numbers to check odd or even");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine($"The number {a} is even");
            }
            else
            {
                Console.WriteLine($"The number {a} is odd");
            }

        }
    }
}
