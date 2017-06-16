using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2_getdata
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Employee() { }

        public Employee(int id, string name, decimal sal)
        {
            Id = id;
            Name = name;
            Salary = sal;
        }

        public override string ToString()
        {
            return string.Format("\nEmployee Details \nId : {0}\nName : {1}\nSalary : {2}", Id, Name, Salary);
        }
    }
}