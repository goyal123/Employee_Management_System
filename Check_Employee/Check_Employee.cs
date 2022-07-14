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
            int emp_check = random.Next(0,2);
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

}
