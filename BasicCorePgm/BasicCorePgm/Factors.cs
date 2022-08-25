using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class Factors
    {
        public void Core()
        {
            int y = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 0)
            {
                for (int i = 2; i < n; i++)            //factors are only from 2 to the half of the number
                {
                    if (n % i == 0)
                    {
                        int x = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            if (i % j == 0)
                            {
                                x++;
                            }
                        }
                        if (x == 2)
                        {
                            y = 1;
                            Console.WriteLine(i + " ");
                        }
                    }
                }
                if (y == 0)
                {
                    Console.WriteLine($"There is no prime factor for {n}");
                }
            }
            else
            {
                Console.WriteLine("Invalud input, negative integers are not allowed");
            }
        }
    }
}
   
