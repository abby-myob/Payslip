using System;
using System.IO.Pipes;
using System.Security.Principal;

namespace PayslipsFirstSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.Welcome);

            var person = new Person
            {
                FirstName = Printer.StringInputValidation(Constants.FirstNameInput),
                LastName = Printer.StringInputValidation(Constants.LastNameInput),
                AnnualSalary = Printer.NumberInputValidation(Constants.AnnualSalaryInput),
                SuperRate = Printer.NumberInputValidation(Constants.SuperRateInput),
                PaymentStartDate = Printer.StartDateInputValidation(Constants.PaymentStartDateInput),
                //PaymentEndDate = //Start date + A Month
            };
            

            PayslipLogic payslip = new PayslipLogic(person);
            
            payslip.CalculateFullName();
            payslip.CalculatePayPeriod();
            payslip.CalculateGrossIncome();
            payslip.CalculateIncomeTax();
            payslip.CalculateNetIncome();
            payslip.CalculateSuper();


            Printer.PrintPayslip(person);
        }
    }
}