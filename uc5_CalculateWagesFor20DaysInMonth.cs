using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class uc5_CalculateWagesFor20DayslnMonth
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HRS = 50;
        public const int NUM_OF_WORKING_DAYS = 20;
       public static void Main5()
        {
            //variables
            int empHrs = 0, empWage = 0, totalEmpWage = 0;
            //computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HRS;
                totalEmpWage += empWage;
                Console.WriteLine(" Emp Wage : " + empWage);
            }
        }
    }
}
