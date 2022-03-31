using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem

{
    public class EmployeeWageProblem
    {
        public void Attendence()
        {
            Random random = new Random();
            int EmpCheck = random.Next(3);
            int WagePerHour = 20;
            int WorkingHour = 0;
            int EmployeeWage;

            if (EmpCheck == 1)
            {
                Console.WriteLine("Employee is present For Full Time");
                WorkingHour = 8;
            }

            else if (EmpCheck == 2)
            {
                Console.WriteLine("Employee is present For Part Time");
                WorkingHour = 4;
            }

            else
            Console.WriteLine("Employee is absent ");
            EmployeeWage = WagePerHour * WorkingHour;
            Console.WriteLine("Employee Wage is {0}", EmployeeWage);

        }
    }
}
