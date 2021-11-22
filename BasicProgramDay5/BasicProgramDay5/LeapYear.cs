using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramDay5
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            Console.WriteLine("Enter the Leap Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year.ToString().Length == 4)
            {
                if (year % 4 == 0)
                    Console.WriteLine(" This is Leap Year ");
                else
                    Console.WriteLine("This is not Year Year ");
            }
            else
                Console.WriteLine("Enter the Valid Year ");
        }
    }
}
