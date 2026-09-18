using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Prog2.Session_05.Bài_5
{
    internal abstract class Employee
    {
        protected string firstName;
        protected string lastName;
        protected string SSN;

        public Employee(string firstName, string lastName, string SSN)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.SSN = SSN;
        }

        public abstract decimal earnings();

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName}\nsocial security number: {SSN}\n";
        }

    }
}
