using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        /// <summary>
        /// UC1- Finding out whether employee is present or absent
        /// UC2- Calculating the daily wages of the Employee
        /// UC3- Adding Part time employee and Calculate the Wages
        /// UC4- Calculating above UC using switch case
        /// UC5- Calculating Monthly Wages of Employee
        /// UC6- Calculating The wages till the condition of 100hr or for 20days
        /// UC7- Computing the Employee wages using class method
        /// UC8- Computing the employee wages for multiple company
        /// UC9- Saving total wages for each company using class EmployeeBuilder
        /// UC10-Manage multiple companies using array
        /// UC11-Creating API procedure
        /// UC12-Manage multiple companies using Array list
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// 


        //class method to compute the employee wages
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //creating object for each company
            EmployeeWageBuilder employeeWage = new EmployeeWageBuilder();
            employeeWage.addDetail("Reliance", 20, 25, 100);
            employeeWage.addDetail("Big-Bazaar", 50, 30, 150);
            employeeWage.ComputeWage();
            Console.Read();
        }
    }
}
