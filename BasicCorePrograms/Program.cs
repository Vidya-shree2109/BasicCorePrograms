using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To Basic Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Flip Coin\n2.Leap Year\n3.Power Of Two\n4.End the program");
            while(finish)
            {
                Console.WriteLine("\nEnter an option to execute :");
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
                    case 4: finish = false;
                        break;

                    default: Console.WriteLine("Enter a valid option !");
                        break;
                }
            }

        }
    }
}