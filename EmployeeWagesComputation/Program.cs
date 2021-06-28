using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        //adding constant global variable
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HR = 20;

        /// <summary>
        /// UC1- Finding out whether employee is present or absent
        /// UC2- Calculating the daily wages of the Employee
        /// UC3- Adding Part time employee and Calculate the Wages
        /// UC4- Calculating above UC using switch case 
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //initialize local variable 
            int empHrs = 0;
            int empWages = 0;

            //Creating object or instance of Random class
            Random random = new Random();

            //Generating Random value by calling Next Method
            int empInput= random.Next(0, 3);
            
            //Checking employee status using switch case statement
            switch(empInput)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Full time Employee");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Part time Employee");
                    empHrs = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent");
                    break;
            }

            //calculating Daily wages of Employee by Working Hours
            empWages = empHrs * EMP_RATE_PER_HR;

            Console.WriteLine("Daily wages for the Employee = "+empWages);
            Console.Read();
        }
    }
}
