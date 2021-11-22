using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter the Power");
            int n = Convert.ToInt32(Console.ReadLine());
            if(n>0 && n <31)
            {
                for(int i = 0; i <n; i++)
                {
                    Console.WriteLine("2^{0} = {1} ",i,Math.Pow(2,i));
                }
            }

        }
    }
}
