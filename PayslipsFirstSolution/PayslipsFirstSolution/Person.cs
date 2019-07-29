
namespace PayslipsFirstSolution
{
    public class Person
    {
        private string FullName;
        public string FirstName;
        public string LastName;
        public int AnnualSalary;
        public int Super;
        public string PaymentStartDate;
        public string PaymentEndDate;

        
        
        public void NameGenerator()
        {
            if (FirstName != null && LastName != null)
            {
                FullName = FirstName + " " + LastName;
            }
        }
    }
}