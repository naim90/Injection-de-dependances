﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class MonthlySalaryCalculator:ISalaryCalculator
    {

        public Double CalculateSalary(Double yearlyAmount)

        {

            return yearlyAmount / 12;

        }

    }
}
