namespace Emp_Manage_Sys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management System");
            //Check_Employee.Emp_check();
            Check_Employee_Wage wage = new Check_Employee_Wage();
            wage.empWage();



           

        }
    }
}