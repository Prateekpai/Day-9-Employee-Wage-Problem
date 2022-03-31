using System;

namespace MyApplication
{
    public class EmployeePresent
    {
        public void Attendence()
        {
            Random random = new Random();
            int EmpCheck = random.Next(3);

            if (EmpCheck == 1)
                Console.WriteLine("Employee is present");
            else if (EmpCheck == 2)
                Console.WriteLine("Employee is present for Part Time");
            else
                Console.WriteLine("Employee is absent");

        }
    }
}
