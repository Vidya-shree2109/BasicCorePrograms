using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LargestOfThreeNumbers
    {
        public void Largest()
        {
            Console.WriteLine("\nProgram To Find Largest Of Three Numbers\n");
            int num1, num2, num3;
            Console.Write("Enter the 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 3st number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("\n{0} is the Largest Number !", num1);
                }
                else
                {
                    Console.WriteLine("\n{0} is the Largest Number !", num3);
                }
            }
            else if (num2 > num3)
                Console.WriteLine("\n{0} is the Largest Number !", num2);
            else
                Console.WriteLine("\n{0} is the Largest Number ", num3);
        }
    }
}
