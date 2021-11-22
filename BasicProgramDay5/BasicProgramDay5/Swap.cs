using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class Swap
    {
      public int n1, n2, temp;
        public void Swapping()
        {
            Console.WriteLine("Enter First number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("First Number is " + n1);
            Console.WriteLine("Second Number is " + n2);
        }
    }
}
