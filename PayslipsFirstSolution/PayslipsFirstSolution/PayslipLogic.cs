using System;
using System.ComponentModel.Design;

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
            int income = _person.AnnualSalary;
            int result = 0;
            
            if (income <= 18200)
            {
                result = 0;
            } 
            else if (income >= 18201 && income <= 37000)
            {
                result = (int) (((income - 18200) * 0.19)/12);
            } 
            else if (income >= 37001 && income < 87000)
            {
                result = (int) ((3572 + (income - 37000) * 0.325)/12);
            }
            else if (income >= 87001 && income < 180000)
            {
                result = (int) ((19822 + (income - 87000) * 0.37)/12);
            }
            else if (income >= 180001)
            {
                result = (int) ((54232 + (income - 18000) * 0.45)/12);
            }
            
            //round the boy

            _person.IncomeTax = result;
        }

        public void CalculateNetIncome()
        {
            _person.NetIncome = _person.GrossIncome - _person.IncomeTax;
        }
        
        public void CalculateSuper()
        {
            _person.Super = Convert.ToInt32(Math.Floor((decimal) (_person.GrossIncome * _person.SuperRate / 100)));
            
        }

        
    }
}