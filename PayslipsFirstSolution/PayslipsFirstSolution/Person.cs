
namespace PayslipsFirstSolution
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int AnnualSalary;
        public int SuperRate;
        public string PaymentStartDate;
        public string PaymentEndDate;

        private string FullName;
        public string PayPeriod;
        public int GrossIncome;
        public int IncomeTax;
        public int Super;

        public void NameGenerator()
        {
            if (FirstName != null && LastName != null)
            {
                FullName = FirstName + " " + LastName;
            }
        }
    }
}