using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndRemainder
    {
        public void FindQuotientRemainder()
        {
			int x, y, quotient, remainder;
			Console.WriteLine("Enter first number (Dividend) :");
			x = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Enter second number (Divisor) :");
			y = Convert.ToInt32(Console.ReadLine());

			quotient = x / y;
			remainder = x % y;

			Console.Write("Quotient  --> {0} / {1} = ",x,y);
			Console.WriteLine(quotient);
			Console.Write("Remainder --> {0} % {1} = ",x,y);
			Console.WriteLine(remainder);
		}
    }
}
