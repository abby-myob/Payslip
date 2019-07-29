using System;
using System.Text.RegularExpressions;

namespace PayslipsFirstSolution
{
    public static class Printer /*: IPrinter*/
    {

        public static string StringInputValidation(string message)
        {
            var res = "";
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


        public static int AnnualSalaryValidation(string message)
        {
            var salary = 0;
            while (true)
            {
                Console.Write(message);
                var res = Console.ReadLine();

                if (res != null && Int32.TryParse(res, out salary))
                {
                    //salary with the right numbers
                    break;
                }
                else
                {
                    Console.WriteLine(Constants.OnlyNumbers);
                }

            }
            return salary;
        }
    }
}