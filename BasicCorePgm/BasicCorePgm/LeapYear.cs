using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
    internal class LeapYear
    {
        public void Core()
        {
            Console.WriteLine("Enter the 4 digit year you wish to check for leap year");
            int year = Convert.ToInt32(Console.ReadLine());
            int limit = 1000;
            int leap = year % 4;
            if (year >= limit)
            {
                if (leap == 0)
                {
                    Console.WriteLine($"{year} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{year} is not a leap year");
                }

            }
            else
            {
                Console.WriteLine("Invalid input only 4 digit years are allowed");
            }
        }
    }
}
