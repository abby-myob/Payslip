using System;

namespace PayslipsFirstSolution
{
    class PayslipLogic
    {
        private Person _person;
        public PayslipLogic(Person person)
        {
            _person = person;
        }

        public void CalculateGrossIncome()
        {
            _person.GrossIncome = Convert.ToInt32(Math.Floor((decimal) (_person.AnnualSalary/12)));
        }


        public void CalculateIncomeTax()
        {
            
            
            _person.IncomeTax = 0;
        }
    }
}