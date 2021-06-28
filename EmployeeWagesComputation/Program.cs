using System;

namespace EmployeeWagesComputation
{
    class Program
    {
        //adding constant global variable
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        const int EMP_RATE_PER_HR = 20;
        const int TOTAL_WORKING_DAY = 20;
        const int TOTAL_WORKING_HR = 100;


        /// <summary>
        /// UC1- Finding out whether employee is present or absent
        /// UC2- Calculating the daily wages of the Employee
        /// UC3- Adding Part time employee and Calculate the Wages
        /// UC4- Calculating above UC using switch case
        /// UC5- Calculating Monthly Wages of Employee
        /// UC6- Calculating The wages till the condition of 100hr or for 20days
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wages Computation");
            //initialize local variable 
            int empHrs = 0;
            int empWages = 0;
            int monthlyWages = 0;
            int workingHr = 0;
            int day = 0;
            //Creating object or instance of Random class
            Random random = new Random();
          

            //Calculatin monthly Wages for 20days or for 100Hrs of work
            while(day<=TOTAL_WORKING_DAY && workingHr<TOTAL_WORKING_HR)
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
                empWages = empHrs * EMP_RATE_PER_HR;
                monthlyWages = monthlyWages + empWages;
                workingHr += empHrs;
                if(empInput!=0)
                {
                    day++;
                }

            }

            Console.WriteLine(" Wages of the Employee for "+workingHr+ " Hour or "+day+" days = "+monthlyWages);
            Console.Read();
        }
    }
}
