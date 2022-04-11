using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void FindHarmonic()
        {
            Console.WriteLine("Harmonic Number Program");
            double harmonic = 0.0;
            Console.Write("Enter a Harmonic Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i < num)
                {
                    Console.Write("1/{0} + ", i);
                    harmonic += 1 / (double)i;
                }
                if (i == num)
                {
                    Console.Write("1/{0} + ", i);
                    harmonic += 1 / (double)i;
                }
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} \n", num, harmonic);
        }
    }
}
