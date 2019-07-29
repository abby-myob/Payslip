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

        public static string DateInputValidation(String message)
        {
            while (true)
            {
                Console.Write(message);
                var res = Console.ReadLine();

                if (res != null && Int32.TryParse(res, out var number))
                {
                    
                }
                else
                {
                    Console.WriteLine(Constants.ProvideValidDate);
                }

            }
        }

    }
}