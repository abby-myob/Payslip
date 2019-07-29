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
                PaymentStartDate = Printer.DateInputValidation(Constants.PaymentStartDateInput),
                PaymentEndDate = Printer.DateInputValidation(Constants.PaymentEndDateInput),
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