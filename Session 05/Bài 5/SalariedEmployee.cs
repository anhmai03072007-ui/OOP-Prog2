using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_5
{
    internal class SalariedEmployee : Employee
    {
        protected decimal weeklySalary;
        public SalariedEmployee(string firstName, string lastName, string SSN, decimal weeklySalary) : base(firstName, lastName, SSN)
        {
            this.weeklySalary = weeklySalary;
        }
        public override decimal earnings()
        {
            return (decimal)this.weeklySalary;
        }
        public override string ToString()
        {
            return $"salaried employee: " + base.ToString() + $"weekly salary: {this.weeklySalary}";
            ;
        }
    }
}
