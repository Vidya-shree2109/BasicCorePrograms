using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenOrOdd
    {
        public void FindEvenOrOdd()
        {
            Console.Write("Enter a number to check Even or Odd :");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("\n{0} is an Even Number !", number);
            }
            else
            {
                Console.WriteLine("\n{0} is an Odd Number !", number);
            }
        }
    }
}
