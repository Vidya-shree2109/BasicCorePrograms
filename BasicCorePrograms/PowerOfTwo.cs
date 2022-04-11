using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public void TwoPower()
        {
            Console.WriteLine("Enter the power value to find 2's power : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("2" + " " + "^" + " " + i + " " + "=" + " " + Math.Pow(2,i));
            }
        }
    }
}
