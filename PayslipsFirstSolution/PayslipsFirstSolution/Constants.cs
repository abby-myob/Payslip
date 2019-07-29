using System;
using System.Runtime.ConstrainedExecution;

namespace PayslipsFirstSolution
{
    public static class Constants
    {
        public const string NewLine = "\n";
        
        // Input gathering Strings
        public const string Welcome = "Welcome to the best Payslip Generator you'll ever see\n";
        
        public const string FirstNameInput = "First Name: ";
        public const string LastNameInput = "Last Name: ";
        public const string AnnualSalaryInput = "Annual Salary (ex. 40000): ";
        public const string SuperRateInput = "Super Rate: ";
        public const string PaymentStartDateInput = "Start Date of the Pay Month (DD/MM/YYYY): ";
        public const string PaymentEndDateInput = "End Date of the Pay Month (DD/MM/YYYY): ";
        
        // Payslip information Strings
        public const string PayslipGenerated = "Your Payslip has been generated\n";
        
        public const string Name = "Name: ";
        public const string PayPeriod = "Pay Period: ";
        public const string GrossIncome = "Gross Income: ";
        public const string IncomeTax = "Income Tax: ";
        public const string NetIncome = "Net Income: ";
        public const string Super = "Super: ";
        
        public const string ThankYou = "Thanks for using MYOB! Mind your own business ;)\n";

        // Error Messages
        public const string OnlyLetters = "Please only use Letters"; //what if it's a name with special characters
        public const string OnlyNumbers = "Please type out a number with no $ behind it";
        public const string SuperRequirements = "Please provide your super percentage as a number from 0 to 50";
        public const string ProvideValidStartDate = "Please provide a valid date DD/MM/YYYY";
        public const string ValidStartDate = "This date should be the start of your calendar month (01/MM/YYYY)";
        public const string ValidEndDate = "This date should be the end of your calendar month (DD/MM/YYYY)";
    }
}