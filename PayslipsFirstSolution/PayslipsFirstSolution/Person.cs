
namespace PayslipsFirstSolution
{
    public class Person
    {
        public string FullName;
        public string FirstName;
        public string LastName;
        public int AnnualSalary;

        public void nameGenerator()
        {
            if (FirstName != null && LastName != null)
            {
                FullName = FirstName + LastName;
            }
        }
    }
}