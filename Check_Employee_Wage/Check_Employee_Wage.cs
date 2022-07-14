using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Manage_Sys
{
    public class Check_Employee_Wage:Check_Employee
    {
        public Check_Employee_Wage()
        {
            Console.WriteLine("Please find Employee wage calculation");
        }
        public void empWage()
        { int emp_workHrs = 0, emp_Rate_Per_Hour = 20, emp_wage = 0;
            int FullTime = 1, PartTime = 0;
            int emp_Time;
           Random random=new Random();
            emp_Time=random.Next(0, 2);

            if (Emp_check())
            {   
                if(emp_Time==FullTime)
                {
                    emp_workHrs = 8;
                    Console.WriteLine("Employee is Present Full-Day");
                }
                else
                {
                    emp_workHrs = 4;
                    Console.WriteLine("Employee is Present Half-Day");
                }
                
            }
            else
            {
                emp_workHrs = 0;
                Console.WriteLine("Employee is Absent");
            }

            emp_wage = emp_workHrs * emp_Rate_Per_Hour;
            Console.WriteLine("Employee wage = {0} ", emp_wage);
        }
    }
}
