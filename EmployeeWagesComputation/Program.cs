using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        //adding constant global variable
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;


        /// <summary>
        /// UC1- Finding out whether employee is present or absent
        /// UC2- Calculating the daily wages of the Employee
        /// UC3- Adding Part time employee and Calculate the Wages
        /// UC4- Calculating above UC using switch case
        /// UC5- Calculating Monthly Wages of Employee
        /// UC6- Calculating The wages till the condition of 100hr or for 20days
        /// UC7- Computing the Employee wages using class method
        /// UC8- Computing the employee wages for multiple company
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// 


        //class method to compute the employee wages
        public static void ComputeEmployeeWage(String companyName,int employeeRatePerHr,int maxWorkingDays, int maxWorkingHrs)
        {
            //initialize local variable 
            int empHrs = 0;
            int empWages = 0;
            int monthlyWages = 0;
            int workingHr = 0;
            int day = 0;
            //Creating object or instance of Random class
            Random random = new Random();


            //Calculatin monthly Wages for 20days or for 100Hrs of work
            while (day <= maxWorkingDays && workingHr < maxWorkingHrs)
            {


                //Generating Random value by calling Next Method
                int empInput = random.Next(0, 3);

                //Checking employee status using switch case statement
                switch (empInput)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }

                //calculating Daily wages of Employee by Working Hours
                empWages = empHrs * employeeRatePerHr;
                monthlyWages = monthlyWages + empWages;
                workingHr += empHrs;

                if (empInput != 0)
                {
                    day++;
                }

            }

            Console.WriteLine("Total working days :{0} \nTotal working hours:{1}",day,workingHr);
            Console.WriteLine("Total Employee wage for company \"{0}\" is :{1}\n\n", companyName, monthlyWages);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");

            //calling the class method for multiple company
            ComputeEmployeeWage("Reliance",20,25,100);
            ComputeEmployeeWage("Big-Bazaar",50, 30, 150);

            Console.Read();
        }
    }
}
