using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace PayslipsFirstSolution
{
    public class Printer /*: IPrinter*/
    {
        public Person Person { get; }

        public Printer(Person person)
        {
            Person = person;
        }
        
        public void FirstNameValidator()
        {
            var valid = false;
            while (!valid)
            {
                Console.Write(Constants.FirstNameInput);
                var res = Console.ReadLine();

                if (StringValidation(res))
                {
                    valid = true;
                    //put response into the person object.
                }
            }
        }
        
        public void LastNameValidator()
        {
            
        }

        public void AnnualSalaryValidator()
        {
            
        }

        public void SuperValidator()
        {
            
        }

        public void PaymentStartDateValidator()
        {
            
        }

        public void PaymentEndDateValidator()
        {
            
        }

        
        public bool NumValidation(String message, String validationType)
        {
            //if is what is needed
            return false;
        }

        public bool StringValidation(String str)
        {
            //check all characters are alphabetical
            return false;
        }
    }
}