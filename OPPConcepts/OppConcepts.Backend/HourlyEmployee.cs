using System;
using System.Collections.Generic;
using System.Text;

namespace OppConcepts.Backend
{
    public class HourlyEmployee : Employee
    {
        private decimal _hourValue;

        private float _workingHours;

        public HourlyEmployee(string firstName, int id, bool isActive, string lastName, Date bornDate, Date hireDate, decimal hourValue, float workingHours) : base(firstName, id, isActive, lastName, bornDate, hireDate)
        {
            HourValue = hourValue;
            WorkingHours = workingHours;
        }

        public decimal HourValue
        {
            get => _hourValue;
            set => _hourValue = ValidateHourValue(value);
        }

        public float WorkingHours {
            get => _workingHours;
            set => _workingHours = ValidateWorkingHours(value);
        }


        public override string ToString() => base.ToString() +$"\n\t" +
            $"Hour value...: {HourValue,20:C2}\n\t" +
            $"Working hours: {WorkingHours,20:N2}";

        private decimal ValidateHourValue(decimal hourValue)
        {
            if (hourValue < 10000)
            {
                throw new ArgumentOutOfRangeException(nameof(hourValue), "Hour value must be greater than or equal to $10.000. ");
            }
            return hourValue;
        }

        private float ValidateWorkingHours(float workingHours)
        {
            if (workingHours < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(workingHours), "Working hours must be greather than or equal to 0  ");
            }
            return workingHours;
        }

        public override decimal GetValueToPay() => (decimal)WorkingHours * HourValue;
    }
}
