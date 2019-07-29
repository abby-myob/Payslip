﻿using System;
using System.IO.Pipes;
using System.Security.Principal;

namespace PayslipsFirstSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.Welcome);

            Person person;
            person = new Person
            {
                FirstName = Printer.StringInputValidation(Constants.FirstNameInput),
                LastName = Printer.StringInputValidation(Constants.LastNameInput),
                AnnualSalary = Printer.NumberInputValidation(Constants.AnnualSalaryInput),
                Super = Printer.NumberInputValidation(Constants.SuperRateInput),
                PaymentStartDate = Printer.DateInputValidation(Constants.PaymentStartDateInput),
                PaymentEndDate = Printer.DateInputValidation(Constants.PaymentEndDateInput),
            };
            person.NameGenerator();

            PayslipLogic payslip = new PayslipLogic(person);
            
            
            
            // Do the logic with the details
            // NameCreator.concatenate(person);


            // Print all the details with a printer

        }
    }
}