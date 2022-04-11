using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To Basic Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Flip Coin\n2.Leap Year\n3.Power Of Two\n4.Harmonic Number\n5.Find Prime Factor\n6.Quotient And Remainder\n7.Swap Two Numbers\n8.Even Or Odd\n9.End the program");
            while(finish)
            {
                Console.Write("\nEnter an option to execute :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1: FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.CheckLeapYear();
                        break;
                    case 3:
                        PowerOfTwo power = new PowerOfTwo();
                        power.TwoPower();
                        break;
                    case 4:
                        HarmonicNumber harmonicvalue = new HarmonicNumber();
                        harmonicvalue.FindHarmonic();
                        break;
                    case 5:
                        PrimeFactors factor = new PrimeFactors();
                        factor.FindFactor();
                        break;
                    case 6:
                        QuotientAndRemainder rem = new QuotientAndRemainder();
                        rem.FindQuotientRemainder();
                        break;
                    case 7:
                        SwapTwoNumbers swap = new SwapTwoNumbers();
                        swap.NumberSwap();
                        break;
                    case 8:
                        EvenOrOdd even = new EvenOrOdd();
                        even.FindEvenOrOdd();
                        break;
                    case 9: finish = false;
                        break;

                    default: Console.WriteLine("Enter a valid option !");
                        break;
                }
            }

        }
    }
}