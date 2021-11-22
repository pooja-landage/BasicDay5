using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class FlipCoin
    {
        // intailization
        public double TailCount = 0;
        public double HeadCount = 0;
        public double Tail=0;
        public double Head=0;

        // method
        public void FlipCoinProgram()
        {
            Console.WriteLine("Enter the number of Times you want to Flip Coin ");
            int n = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();

            // n time loop will run
            for(int i = 0; i < n; i++)
            {
                // random Possiblity
                int coin = r.Next(0, 2);

                if (coin < 0.5 )
                {
                    Console.WriteLine("Value:Tails");
                    TailCount = TailCount + 1;
                }
                else
                {
                    Console.WriteLine("Value:Head");
                    HeadCount = HeadCount + 1;  
                }
            }
            //To find Percentage
            Tail = TailCount / n * 100;
            Head = HeadCount / n * 100;
            Console.WriteLine("Percentage of Tail is " + Tail);
            Console.WriteLine("Percentage of Head is " + Head);           
        }

    }
}
