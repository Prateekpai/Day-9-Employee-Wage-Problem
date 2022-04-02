using System;
namespace EmployeeWageProblem
{
    public class Program
    {
        public const int Present = 1;
        public const int PartTime = 2;
        public const int Emp_Wage_per_hour = 20;
        public const int Total_workingDays = 20;
        public const int Total_Emp_Working_Hour = 100;
        public static void EmployeeWageDemo()
        {
            int Emp_hour = 0, TotalEMPHrs = 0, TotalWorkingDays = 0;
            while(TotalEMPHrs<= Total_Emp_Working_Hour && TotalWorkingDays <= Total_workingDays)
            {
                TotalWorkingDays++;
                Random random = new Random();
                int EmployeeCheck = random.Next(2);
                switch(EmployeeCheck)
                {
                    case 1:
                        Emp_hour = 8;
                        break;
                    case 2:
                        Emp_hour = 4;
                        break;
                    case 0:
                        Emp_hour = 0;
                        break;

                }
                TotalEMPHrs += Emp_hour;
                Console.WriteLine("Days: " + TotalWorkingDays + "Working Hours: " + TotalEMPHrs);

            }

            int TotalEmployeeWage = TotalEMPHrs * Emp_Wage_per_hour;
            Console.WriteLine("Total employee Wage " + TotalEmployeeWage);

        }
        public static void Main(string[] args)
        {

            EmployeeWageDemo();

        }
    }

}
