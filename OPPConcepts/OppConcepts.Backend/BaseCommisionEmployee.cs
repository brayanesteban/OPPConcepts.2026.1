using System;
using System.Collections.Generic;
using System.Text;

namespace OppConcepts.Backend
{

    public class BaseCommisionEmployee : CommisionEmployee
    {
        private decimal _Salary;

        public BaseCommisionEmployee(string firstName, int id, bool isActive, string lastName, Date bornDate, Date hireDate, decimal sales, float commisionPercent, decimal salary) : base(firstName, id, isActive, lastName, bornDate, hireDate, sales, commisionPercent)
        {
            _Salary = salary;
        }
            

        public decimal Salary
        {
            get => _Salary;
            set => _Salary = ValidateSalary(value);
        }
        public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 500000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $500.000 " );
            }
            return salary;
        }

        public override string ToString() => base.ToString() +$"\n\t" +
            $"Base salary..: {Salary,20:C2}";
    }
}

