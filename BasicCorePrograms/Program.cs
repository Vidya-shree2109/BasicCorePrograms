using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("----------Welcome To Basic Programs----------");
            bool finish = true;
            Console.WriteLine("\n1.Flip Coin\n2.End the program");
            while(finish)
            {
                Console.WriteLine("\nEnter an option to execute :");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1: FlipCoin flipCoin = new FlipCoin();
                        flipCoin.Flip();
                        break;
                    case 2: finish = false;
                        break;

                    default: Console.WriteLine("Enter a valid option !");
                        break;
                }
            }

        }
    }
}