using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace PayslipsFirstSolution
{
    public class Printer /*: IPrinter*/
    {
        private DateTime _programStartDate = DateTime.Today;

        public string StringInputValidation(string message)
        {
            string res;
            while (true)
            {
                Console.Write(message);
                res = Console.ReadLine();

                if (res != null && Regex.IsMatch(res, @"^[a-zA-Z]+$"))
                {
                    break;
                }
                else
                {
                    Console.WriteLine(Constants.OnlyLetters);
                }
                
            }
            return res;
        }

        public int NumberInputValidation(string message)
        {
            while (true)
            {
                Console.Write(message);
                var res = Console.ReadLine();

                if (res != null && Int32.TryParse(res, out var number))
                {
                    switch (message)
                    {
                        case Constants.AnnualSalaryInput:
                            //requirements
                            return number;
                        case Constants.SuperRateInput when number < 50 && number >= 0:
                            return number;
                        case Constants.SuperRateInput:
                            Console.WriteLine(Constants.SuperRequirements);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine(Constants.OnlyNumbers);
                }

            }
        }

        public DateTime DateInputValidation(string message)
        {
            
            while (true)
            {
                Console.Write(message);

                if (!DateTime.TryParseExact(Console.ReadLine(), "MM/DD/YYYY", new CultureInfo("en-NZ"), DateTimeStyles.None, out DateTime date))
                {
                    Console.WriteLine(Constants.ProvideValidStartDate);
                    continue;
                }
                
                switch (message)
                {
                    case Constants.PaymentStartDateInput:

                        if (date.Day == 1)
                        {
                            _programStartDate = date;
                            return date;
                        }
                        else
                        {
                            Console.WriteLine(Constants.ValidStartDate);
                            continue;
                        }
                    
                    case Constants.PaymentEndDateInput:
                        
                        if (date.Day == DateTime.DaysInMonth(_programStartDate.Month, _programStartDate.Year))
                        {
                            return date;
                        }
                        else
                        {
                            Console.WriteLine(Constants.ValidEndDate);
                            continue;
                        }
                        
                }
                
            }
        }

        public void PrintPayslip(Person person)
        {
            Console.WriteLine(Constants.NewLine);
            Console.WriteLine(Constants.PayslipGenerated);

            Console.WriteLine($"{Constants.Name} {person.FullName}");
            Console.WriteLine($"{Constants.PayPeriod} {person.PayPeriod}");
            Console.WriteLine($"{Constants.GrossIncome} {person.GrossIncome}");
            Console.WriteLine($"{Constants.IncomeTax} {person.IncomeTax}");
            Console.WriteLine($"{Constants.NetIncome} {person.NetIncome}");
            Console.WriteLine($"{Constants.Super} {person.Super}");

            Console.WriteLine(Constants.NewLine);
            Console.WriteLine(Constants.ThankYou);
        }
    }
}