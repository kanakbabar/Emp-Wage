using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class uc2_EmployeeWage
    {
       public static void Main2()
        {
            // constant
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 45;

            //variable
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            //computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 9;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
            Console.ReadLine();
        }
    }
}
