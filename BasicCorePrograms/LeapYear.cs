using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class LeapYear
    {
        public void CheckLeapYear()
        {
            int check_year;
            Console.Write("Enter a year to check for Leap Year : ");
            check_year = Convert.ToInt32(Console.ReadLine());

            if (check_year % 4 == 0 || (check_year % 100 == 0 && check_year % 400 == 0))
            {
                Console.WriteLine("{0} is a leap year.\n", check_year);
            }
            else
            {
                Console.WriteLine("{0} is not a leap year.\n", check_year);
            }
        }
    }
}
