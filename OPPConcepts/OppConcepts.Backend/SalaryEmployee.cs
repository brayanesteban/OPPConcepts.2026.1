using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace OppConcepts.Backend
{
    public class SalaryEmployee : Employee
    {
        private decimal _salary;
        public SalaryEmployee(string firstName, int id, bool isActive, string lastName, Date bornDate, Date hireDate, decimal salary) : base(firstName, id, isActive, lastName, bornDate, hireDate)
        {
            Salary = salary;
        }

        public decimal Salary { get => _salary; set => _salary = ValidateSalary(value); }

        public override decimal GetValueToPay() => Salary;

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 2000000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to $2.000.000 ");
            }
            return salary;
        }

        public override string ToString() => base.ToString();
    }
}
