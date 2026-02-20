using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace OppConcepts.Backend
{
    public class Invoice : IPay
    {
        private decimal _value;
        private float _quantity;

        public Invoice(int id, string description, Date date, float quantity, decimal value)
        {
            Id = id;
            Description = description;
            Date = date;
            Quantity = quantity;
            Value = value;
        }

        public string Description { get; set; }
        public int Id { get; set; }
        public Date Date { get; set; }

        public decimal Value
        {
            get => _value;
            set => _value = ValidateValue(value);
        }

        public float Quantity
        {
            get => _quantity;
            set => _quantity = ValidateQuantity(value);
        }

        public override string ToString() => $"Invoice: {Id}\n" +
            $"Description...: {Description}\n" +
            $"Date..........: {Date}\n" +
            $"Quantity......: {Quantity,20:N2}\n" +
            $"Value.........: {Value,20:C2}\n" +
            $"Total to pay..: {GetValueToPay(),20:C2}";

        public decimal GetValueToPay() => (decimal)Quantity * Value;

        private float ValidateQuantity(float quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(quantity), $"Quantity: {quantity}, is not valid  ");
            }
            return quantity;
        }
        private decimal ValidateValue(decimal value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value), $"Value: {value}, is not valid  ");
            }
            return value;
        }
    }
}
