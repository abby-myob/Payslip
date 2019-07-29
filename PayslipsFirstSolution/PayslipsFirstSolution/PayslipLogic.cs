using System;

namespace PayslipsFirstSolution
{
    class PayslipLogic
    {
        private readonly Person _person;
        
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
            _person.PayPeriod = $"{_person.PaymentStartDate:dd MMMM} - {_person.PaymentEndDate:dd MMMM}";
        }

        public void CalculateGrossIncome()
        {
            _person.GrossIncome = (int) Math.Round((decimal) _person.AnnualSalary/12);
        }
        
        public void CalculateIncomeTax()
        {
            int income = _person.AnnualSalary;
            _person.IncomeTax = 0;
            
            if (income <= 18200)
            {
                _person.IncomeTax = 0;
            } 
            else if (income >= 18201 && income <= 37000)
            {
                _person.IncomeTax = (int) Math.Round((decimal)((income - 18200) * 0.19)/12);
            } 
            else if (income >= 37001 && income < 87000)
            {
                _person.IncomeTax = (int) Math.Round((decimal)(3572 + (income - 37000) * 0.325)/12);
            }
            else if (income >= 87001 && income < 180000)
            {
                _person.IncomeTax = (int) Math.Round((decimal)(19822 + (income - 87000) * 0.37)/12);
            }
            else if (income >= 180001)
            {
                _person.IncomeTax = (int) Math.Round((decimal)(54232 + (income - 18000) * 0.45)/12);
            }
        }

        public void CalculateNetIncome()
        {
            _person.NetIncome = _person.GrossIncome - _person.IncomeTax;
        }
        
        public void CalculateSuper()
        {
            _person.Super = (int) Math.Round((decimal) _person.GrossIncome * _person.SuperRate / 100);
        }
        
    }
}