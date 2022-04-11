using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class SwapTwoNumbers
    {
        public void NumberSwap()
        {
            Console.Write("Enter first number :");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number :");
            int number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nBefore Swapping  -->  Number 1 = {0}   Number 2 = {1}", number1, number2);

            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;

            Console.WriteLine("After Swapping   -->  Number 1 = {0}   Number 2 = {1}", number1, number2);
        }
    }
}
