using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class HarmonicNumber
    {

        public void Harmonic()
        {
            double num = 0;
            Console.WriteLine("Enter the value of HarmonicNumber ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (double i = 0; i < n; i++)
            {
                double value = 1 / i;
                num = num + value;
                Console.WriteLine("Harmonic Number 1/{0} = {1} ", i, value);
            }
            Console.WriteLine("\n {0} th is the Harmonic Value of {1} ", n, num);
        }
    }
}
