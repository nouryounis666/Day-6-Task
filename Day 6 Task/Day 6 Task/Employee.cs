using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Task
{
    internal struct Employee
    {
        private int EmpId;
        private string Name;
        private decimal Salary;

        // Methods
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        // Properties
        public int EmployeeId
        {
            get { return EmpId; }
            set { EmpId = value; }
        }
        public decimal EmployeeSalary
        {
            get { return Salary; }
            set { Salary = value; }
        }

        //override
        public override string ToString()
        {
            return $"Emp Id is {EmpId} \nEmp Name is {Name} \nEmp Salary is {Salary}.";
        }

    }
}
