using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace OppConcepts.Backend
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public string LastName { get; set; }

        public Date BornDate { get; set; }

        public Date HireDate { get; set; }
        
        public Employee() { 
        }
        public abstract decimal GetValueToPay();

        public override string ToString()
        {
            return $"{Id} {FirstName} ({LastName})";
        }

    }
}

    

