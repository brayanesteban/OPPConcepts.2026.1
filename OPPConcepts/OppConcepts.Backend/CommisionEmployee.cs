using System;
using System.Collections.Generic;
using System.Text;

namespace OppConcepts.Backend
{
    public class CommisionEmployee : Employee
    {

        private float _commisionPercent;
        private decimal _sales;

        public float CommisionPercent { 
            get => _commisionPercent; 
            set => _commisionPercent = ValidateCommisionPercent(value);
        }
        public decimal Sales { 
            get => _sales; 
            set => _sales = ValidateSales(value);
        }

        public CommisionEmployee(string firstName, int id, bool isActive, string lastName, Date bornDate, Date hireDate, decimal sales, float commisionPercent) : base(firstName, id, isActive, lastName, bornDate, hireDate)
        {
            CommisionPercent = commisionPercent;
            Sales = sales;
        }
        public override decimal GetValueToPay() => Sales * (decimal)CommisionPercent;

        public override string ToString() => base.ToString() +$"\n\t" +
            $"Sales........: {Sales,20:C2}\n\t" +
            $"Commision....: {CommisionPercent,20:P2}";

        private float ValidateCommisionPercent(float commisionPercent)
        {
            if (commisionPercent < 0 || commisionPercent > 1)
            {
                throw new ArgumentOutOfRangeException(nameof(commisionPercent), "Commision percent must be between 0 and 1. ");
            }
            return commisionPercent;
        }

        private decimal ValidateSales(decimal sales)
        {
            if (sales < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to 0. ");
            }
            return sales;
        }
    }
}
