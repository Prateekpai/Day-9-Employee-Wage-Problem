using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageProblem

{
        public class EmployeePresent
        {
            public void Attendence()
            {
                Random random = new Random();
                int EmpCheck = random.Next(2);
                int WagePerHour = 20;
                int WorkingHour = 0;
                int EmployeeWage;

                if (EmpCheck == 1)
                {
                Console.WriteLine("Employee is Present");
                WorkingHour = 8;
                }

                else
                    Console.WriteLine("Employee is absent ");
                EmployeeWage = WagePerHour * WorkingHour;
                Console.WriteLine("Employee Wage is {0}", EmployeeWage);

            }
        }
}
