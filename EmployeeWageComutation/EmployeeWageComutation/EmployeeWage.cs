
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeWageComputation
{
    class EmployeeWage
    {
        const int PART_TIME = 1,
                  FULL_TIME = 2,
                  RATE_PER_HR = 20,
                  NUM_WORKING_DAYS = 20,
                  MAX_HRS_IN_MONTH = 100;
        public void CalculateEmpWage()
        {
            int empHrs = 0,
                 totalEmpHrs = 0,
                 totalWorkingDays = 0;
            //Comutation
            while (totalEmpHrs <= MAX_HRS_IN_MONTH && totalWorkingDays <= NUM_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random(); //it is using to generate random number
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case PART_TIME:
                        empHrs = 4;
                        break;
                    case FULL_TIME:
                        empHrs = 8;
                        break;
                    defaults:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + "EMP_Hrs:" + empHrs);
            }

            int totalEmpWage = totalEmpHrs * RATE_PER_HR;
            Console.WriteLine("Total Emp Wage:" + totalEmpWage);
        }
    }
}