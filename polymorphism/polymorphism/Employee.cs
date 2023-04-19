using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    internal class Employee : Person
    {
        public string EmpID;
        public double Salary;

        public Employee() : base()
        {
            // Default constructor
        }

        public Employee(string fname, string lname, int age, string empID, double salary)
            : base(fname, lname, age)
        {
            EmpID = empID;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"{fname} {lname} {age} years old, Employee ID: {EmpID}, Salary: {Salary:C}";
        }

        public override string DisplayInfo()
        {
            return $"First name: {fname} \nLast name: {lname} \nAge: {age} \nEmployee ID: {EmpID} \nSalary: {Salary:C}";
        }
    }
}
