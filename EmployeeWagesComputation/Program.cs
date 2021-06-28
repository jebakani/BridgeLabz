using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        /// <summary>
        /// UC1- Finding out whether employee is present or absent
        /// UC2- Calculating the daily wages of the Employee
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //initialize local variable 
            int employeePresent = 1;
            int empHrs = 0;
            int empRatePerHour = 20;
            int empWages = 0;

            //Creating object or instance of Random class
            Random random = new Random();

            //Generating Random value by calling Next Method
            int empInput= random.Next(0, 2);
            
            // Executing select statement for checking employee is present or absent
            if(empInput==employeePresent)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }

            //calculating Daily wages of Employee by Working Hours
            empWages = empHrs * empRatePerHour;

            Console.WriteLine("Daily wages for the Employee = "+empWages);
            Console.Read();
        }
    }
}
