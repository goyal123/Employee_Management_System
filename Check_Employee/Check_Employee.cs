using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp_Manage_Sys
{
    public class Check_Employee
    {
        public static void Emp_check()
        {  
            Random random = new Random();
            int emp_check = random.Next(0, 2);
            int Present = 1,emp_workHrs=0,emp_Rate_Per_Hour=20,emp_wage=0;

            if(emp_check==Present)
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
