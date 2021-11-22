using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class EvenAndOdd
    {
        public void EvenOddFunction()
        {
            int n;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("Number is Even number");
            else
                Console.WriteLine("Number is odd number");
        }
    }
}
