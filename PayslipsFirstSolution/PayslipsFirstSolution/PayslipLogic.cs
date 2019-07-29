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
        
        
        public void CalculateFullName()
        {
            if (_person.FirstName != null && _person.LastName != null)
            {
                _person.FullName = $"{_person.FirstName} {_person.LastName}";
            }
        }

        public void CalculatePayPeriod()
        {
            _person.PayPeriod = $"{_person.PaymentStartDate} - {_person.PaymentEndDate}";
        }

        public void CalculateGrossIncome()
        {
            _person.GrossIncome = Convert.ToInt32(Math.Floor((decimal) (_person.AnnualSalary/12)));
        }
        
        public void CalculateIncomeTax()
        {
            _person.IncomeTax = 0;
        }

        public void CalculateNetIncome()
        {
            _person.NetIncome = _person.GrossIncome - _person.IncomeTax;
        }
        
        public void CalculateSuper()
        {
            _person.Super = Convert.ToInt32(Math.Floor((decimal) (_person.GrossIncome * _person.SuperRate)));
            
        }

        
    }
}