using System;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace PayslipsFirstSolution
{
    public static class Printer /*: IPrinter*/
    {

        public static string StringInputValidation(string message)
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

        public static int NumberInputValidation(string message)
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

        public static string DateInputValidation(String message) // TODO implement validation.
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        public static void PrintPayslip(Person person)
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