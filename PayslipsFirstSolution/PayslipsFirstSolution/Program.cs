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

            Person person;
            person = new Person
            {
                FirstName = Printer.StringInputValidation(Constants.FirstNameInput),
                LastName = Printer.StringInputValidation(Constants.LastNameInput),
                AnnualSalary = Printer.AnnualSalaryValidation(Constants.AnnualSalaryInput),
            };



//            printer.LastNameValidator();
//            printer.AnnualSalaryValidator();
//            printer.SuperValidator();
//            printer.PaymentStartDateValidator();
//            printer.PaymentEndDateValidator();





            // Save the details in a person class.

            // Do the logic with the details
            // NameCreator.concatenate(person);


            // Print all the details with a printer

        }
    }
}