using System;
using System.IO.Pipes;
using System.Security.Principal;

namespace PayslipsFirstSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            // Print questions 
            Console.WriteLine(Constants.Welcome);

            Person person = new Person();
            Printer printer = new Printer(person);

            printer.FirstNameValidator();
            printer.LastNameValidator();
            printer.AnnualSalaryValidator();
            printer.SuperValidator();
            printer.PaymentStartDateValidator();
            printer.PaymentEndDateValidator();





            // Save the details in a person class.

            // Do the logic with the details
            // NameCreator.concatenate(person);


            // Print all the details with a printer

        }
    }
}