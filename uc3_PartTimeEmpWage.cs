using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class uc3_PartTimeEmpWage
    {
       public static void Main3()
        {
            //constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HRS = 50;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            // computation
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HRS;
            Console.WriteLine("Emp Wage : " + empWage);
            Console.ReadLine();
        }
    }
}
