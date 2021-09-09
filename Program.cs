using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day4
{
    class program
    {
       public static void Main(string[] args)
        {
            uc1_EmployeeAttendance.Main1();
            uc2_EmployeeWage.Main2();
            uc3_PartTimeEmpWage.Main3();
            uc4_EmployeeWageUsingSwitch.Main4();
            uc5_CalculateWagesFor20DayslnMonth.Main5();
            uc6_CalculateWageTill100HrsOr20IsReached.Main6();
            uc7_ComputeEmpWageUsingClassMethod.Main7();
            uc8_ComputeEmpWageForMultipleCompanies.Main8("reliance",25,2,10);
            Console.ReadLine();
        }
    }
}
