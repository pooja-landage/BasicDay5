using System;
using BasicProgramDay5;

namespace DAY5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t=====================List Of Basic Program==================");
            Console.WriteLine();
            Console.WriteLine("\t\t\t\t\t\t1.Flip Coin");
            Console.WriteLine("\t\t\t\t\t\t2.Leap Year");
            Console.WriteLine("\t\t\t\t\t\t3.Power of 2");
            Console.WriteLine("\t\t\t\t\t\t4.Harmonic Number");
            Console.WriteLine("\t\t\t\t\t\t5.Factor");
            Console.WriteLine("\t\t\t\t\t\t6.Compute Quotient and Remainder");
            Console.WriteLine("\t\t\t\t\t\t7.Swap Two Numbers");
            Console.WriteLine("\t\t\t\t\t\t8.Even and Odd");
            Console.WriteLine("\t\t\t\t\t\t9.Alphabet is Vowel And Consonant");
            Console.WriteLine("\t\t\t\t\t\t10.Largest Among 3 number");

            Console.Write("\t\t\t\t\t\t ENTER YOUR CHOICE:");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Welcome To Flip Coin Program ");
                    FlipCoin coin = new FlipCoin();
                    coin.FlipCoinProgram();
                    break;

                case 2:
                    Console.WriteLine("Welcome to Year Program ");
                    LeapYear y = new LeapYear();
                    y.CheckLeapYear();
                    break;

                case 3:
                    Console.WriteLine("Welcome to Power of 2 Program ");
                    PowerOfTwo Power = new PowerOfTwo();
                    Power.Power();
                    break;

                case 4:
                    Console.WriteLine("Welcome to Harmonic Number Program ");
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.Harmonic();
                    break;

                case 5:
                    Console.WriteLine("Welcome to Factor Program ");
                    Factor factor = new Factor();
                    factor.FactorProblem();
                    break;

                case 6:
                    Console.WriteLine("Welcome To Division Program ");
                    Division div = new Division();
                    div.DivisionProblem();
                    break;

                case 7:
                    Console.WriteLine("Welcome To Swapping Program ");
                    Swap swap = new Swap();
                    swap.Swapping();
                    break;

                case 8:
                    Console.WriteLine("Welcome To Even and Odd Program");
                    EvenAndOdd num = new EvenAndOdd();
                    num.EvenOddFunction();
                    break;

                case 9:
                    Console.WriteLine("Welcome to Alphabet is Vowel And Consonant");
                    Alphabet alphabet = new Alphabet();
                    alphabet.Vowel();
                    break;

                case 10:
                    Console.WriteLine("Welcome to Largest Program ");
                    LargestNumber largest = new LargestNumber();
                    largest.Largest();
                    break;
            }
        }

    }
}






