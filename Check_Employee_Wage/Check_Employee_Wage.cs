using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Manage_Sys
{
    public class Check_Employee_Wage : Check_Employee
    {
        public Check_Employee_Wage()
        {
            Console.WriteLine("Please find Employee wage calculation");
        }
        public void empWage()
        {
            int emp_workHrs = 0, emp_Rate_Per_Hour = 20, emp_wage = 0;
            int FullTime = 1;
            int emp_Time,work_Day=0;
            Random random = new Random();
            for (int day = 1; day <= 30; day++)
            {
                emp_Time = random.Next(0, 2);
                if (Emp_check())
                {
                    if (emp_Time == FullTime)
                    {
                        emp_workHrs = emp_workHrs + 8;
                        work_Day++;
                        //Console.WriteLine("Employee is Present Full-Day");
                    }
                    else
                    {
                        emp_workHrs = emp_workHrs + 4;
                        work_Day++;
                        //Console.WriteLine("Employee is Present Half-Day");
                    }

                }
                else
                {
                    emp_workHrs = emp_workHrs + 0;
                    work_Day++;
                    //Console.WriteLine("Employee is Absent");
                }

                if (emp_workHrs > 160 || work_Day>20)
                    break;

                //emp_wage = emp_workHrs * emp_Rate_Per_Hour;
                //Console.WriteLine("Employee wage at Day {0} = {1} for {2} working hours ",work_Day, emp_wage,emp_workHrs);

            }
            emp_wage = emp_workHrs * emp_Rate_Per_Hour;
            Console.WriteLine("Total Employee wages of month = {0} ", emp_wage);
        }
    }
}
