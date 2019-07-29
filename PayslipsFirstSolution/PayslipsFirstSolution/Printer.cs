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
            var res = "";
            var salary = 0;
            while (true)
            {
                Console.Write(message);
                res = Console.ReadLine();
                //turn res into integer 

                //check for only numbers
                
                //check for the size of the number
                if (res != null)
                {
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