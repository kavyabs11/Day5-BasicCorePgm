using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePgm
{
   public class CoinFlip
    {
        public void Core()
        {
            double head = 0, tail = 0;
            double limit = 0.5;
            Console.WriteLine("Enter the number of time the coin to be flipped");
            int flip = Convert.ToInt32(Console.ReadLine());
            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random random = new Random();
                    double output = random.Next(0, 2);
                    if (output > limit)
                    {
                        Console.WriteLine("Head");
                        head += 1;
                    }
                    else
                    {
                        Console.WriteLine("Tail");
                        tail += 1;
                    }
                }
                double headPer = (head / flip) * 100;
                double tailPer = (tail / flip) * 100;
                Console.WriteLine($"The percentage of head is {headPer}");
                Console.WriteLine($"The percentage of tail is {tailPer}");
            }
            else
            {
                Console.WriteLine("Invalid input only positive integers are allowed");
            }
        }
    }
}
