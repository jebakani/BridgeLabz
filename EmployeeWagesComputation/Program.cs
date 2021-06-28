using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        /// <summary>
        /// UC1- Finding out whether employee is present or absent
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //initialize local variable 
            int employeePresent = 1;

            //Creating object or instance of Random class
            Random random = new Random();

            //Generating Random value by calling Next Method
            int empInput= random.Next(0, 2);
            
            // Executing select statement for checking employee is present or absent
            if(empInput==employeePresent)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            Console.Read();
        }
    }
}
