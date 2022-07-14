using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Manage_Sys
{
    public class Check_Employee
    {
        public static bool Emp_check()
        {
            int Present = 1;
            Random random = new Random();
            int emp_check = random.Next(0, 2);
            if (emp_check == Present)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }

    }


    public class Check_Employee_Wage:Check_Employee
    {
        public Check_Employee_Wage()
        {
            Console.WriteLine("Please find Employee wage calculation");
        }
        public void empWage()
        { int emp_workHrs = 0, emp_Rate_Per_Hour = 20, emp_wage = 0;

            if (Emp_check())
            {
                emp_workHrs = 8;
                Console.WriteLine("Employee is Present");
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
