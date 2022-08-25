using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    public class QutandRem
    {
        public void core()
        {
            Console.WriteLine("Enter two numbers to find remainder and quotient");
            int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
            if ((a > 0) && (b > 0))
            {
                Console.WriteLine($"The quotient is {a/b}");
                Console.WriteLine($"The remainder is {a % b}");
            }
            else
            {
                Console.WriteLine("Invalud input, negative integers are not allowed");
            }
        }
    }
}
   
