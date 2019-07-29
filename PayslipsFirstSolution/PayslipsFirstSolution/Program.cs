using System;

namespace PayslipsFirstSolution
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.Welcome);
            var p = new Printer();
            
            var person = new Person
            {
                FirstName = p.StringInputValidation(Constants.FirstNameInput),
                LastName = p.StringInputValidation(Constants.LastNameInput),
                AnnualSalary = p.NumberInputValidation(Constants.AnnualSalaryInput),
                SuperRate = p.NumberInputValidation(Constants.SuperRateInput),
                PaymentStartDate = p.DateInputValidation(Constants.PaymentStartDateInput),
                PaymentEndDate = p.DateInputValidation(Constants.PaymentEndDateInput),
           };
            
            PayslipLogic payslip = new PayslipLogic(person);
            
            payslip.CalculateFullName();
            payslip.CalculatePayPeriod();
            payslip.CalculateGrossIncome();
            payslip.CalculateIncomeTax();
            payslip.CalculateNetIncome();
            payslip.CalculateSuper();


            p.PrintPayslip(person);
        }
    }
}