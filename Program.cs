namespace Emp_Manage_Sys
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Management System");
            //Check_Employee.Emp_check();
            Check_Employee_Wage obj1 = new Check_Employee_Wage("Deloitte",20);
            obj1.empWage();

            Check_Employee_Wage obj2 = new Check_Employee_Wage("Tcs",25);
            obj2.empWage();

            Check_Employee_Wage obj3 = new Check_Employee_Wage("Cognizant",10);
            obj3.empWage();






        }
    }
}
