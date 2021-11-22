using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class LargestNumber
    {
        public void Largest()
        {
            int n1,n2, n3;
            Console.WriteLine("Problem:Find largest among three numbers");
            Console.WriteLine("Enter First number");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third number");
            n3 = Convert.ToInt32(Console.ReadLine());
            if (n1 > n2 && n1 > n3)
                Console.WriteLine("Firsr Number {0} is greater number ", n3);
            else if (n2 > n1 && n2 > n3)
                Console.WriteLine("Second Number {0} is greater number ", n2);
            else
                Console.WriteLine("Third number {0} is greater number ", n3);
        }
    }
}
