using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class Division
    {
        
        public void DivisionProblem()
        {
            int Divisor, Divided;
            double Remainder, Quotient;

            Console.WriteLine("Enter the Divided and Divisor ");
            Divided = Convert.ToInt32(Console.ReadLine());
            Divisor = Convert.ToInt32(Console.ReadLine());
            Quotient = Divided / Divisor;
            Remainder = Divided % Divisor;
            Console.Write("The Divsion of {0} by {1}  ",Divided, Divisor);
            Console.WriteLine("Quotient is {0} is and Remainder is {1} ", Quotient, Remainder);

        }

    }
}
