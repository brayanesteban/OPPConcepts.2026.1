using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OppConcepts.Backend
{
    public abstract class Employee
    {
        protected Employee(string firstName, int id, bool isActive, string lastName, Date bornDate, Date hireDate)
        {
            FirstName = firstName;
            Id = id;
            IsActive = isActive;
            LastName = lastName;
            BornDate = bornDate;
            HireDate = hireDate;
        }

        public string FirstName { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string LastName { get; set; }

        public Date BornDate { get; set; }

        public Date HireDate { get; set; }
        

        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id}\t{FirstName} {LastName}\n\t"+  
            $"Value to pay.: {GetValueToPay(),20:C2}";
        }

    }
}

    

