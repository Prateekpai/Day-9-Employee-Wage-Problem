using System;
using System.Collections.Generic;
using System.Text;
namespace EmployeeWageProblem
{
    public class Employee
    {
        public  void EmployeeCheck()
        {
            int EmployeeAbsent = 0;
            int EmployeePresentFullTime = 1;
            int EmployeePresentPartTime = 2;
            int EmployeeWagePerHour = 20;
            int WorkingHour = 0;
            int WageFullTime;

            Random random = new Random();
            int EmployeeCheck = random.Next(3);


            switch (EmployeeCheck)

            {
                case 0:
                    Console.WriteLine("Employee Wage is Absent");
                    WorkingHour = 0;
                    break;

                case 1:
                    Console.WriteLine("Employee is Present For Full Day " );
                    WorkingHour = 8;
                    break;

                case 2:
                    Console.WriteLine("Employee is Present For Part Time " );
                    WorkingHour = 4;
                    break;    
            }
            WageFullTime = EmployeeWagePerHour * WorkingHour;
            Console.WriteLine("Employee Wage is {0}", WageFullTime);
        }
    }
}
