﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWagesComputation
{
    public interface IComputeEmpWage
    {
        public void addDetail(string companyName, int employeeRatePerHr, int maxWorkingDays, int maxWorkingHrs);
        public void ComputeWage();
      
    }
}
