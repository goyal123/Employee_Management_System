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
            if(emp_check==0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }

    }
}
