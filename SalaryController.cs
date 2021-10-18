using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    [Route("api/[controller]")]

    public class SalaryController

    {

        private ISalaryCalculator _calculator;


        public SalaryController(ISalaryCalculator injectedCalculator)

        {

            _calculator = injectedCalculator;

        }


        [HttpGet("yearlyAmount")]

        public Double Get(Double yearlyAmount)

        {

            Double calculatedSalary = _calculator.CalculateSalary(yearlyAmount);

            return calculatedSalary;

        }

    }
}
