using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class Swap
    {
        public void Core()
        {
            int a, b, c = 0;
            Console.WriteLine("Enter two numbers to swap");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            a = b;
            b = c;
            Console.WriteLine($"{a}\n{b}");

        }
    }
}
