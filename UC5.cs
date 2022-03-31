using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC5Problem
{
    public class Demo
    {
        public  void Attendence()
        {

            int WagePerHour = 20;
            int WorkingHour = 0;
            int WagePerDay;
            int WorkingDaysPerMonth = 20;
            int WagePerMonth;


            Random random = new Random();
            int EmployeeCheck = random.Next(3);

            {
                if (EmployeeCheck == 1)

                {
                    Console.WriteLine("Employee Pesent for Full Time" );
                    WorkingHour = 8;
                }

                else if (EmployeeCheck == 2)
                {
                    Console.WriteLine("Employee Pesent for Part Time");
                    WorkingHour = 4;
                }
                else

                {
                    Console.WriteLine("Employee is Absent");
                }
            }
            WagePerDay = WagePerHour * WorkingHour;
            WagePerMonth = WagePerDay * WorkingDaysPerMonth;
            Console.WriteLine("The Employee Wage for the Month is {0}", WagePerMonth);

        }
    }
}
