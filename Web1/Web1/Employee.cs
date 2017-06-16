using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web1
{
    public class Employee
    {
        int _id;
        string _name;
        decimal _salary;

        public int Id { get { return _id; } }

        public string Name { get { return _name; } set { _name = value; } }

        public decimal Salary { get { return _salary; } set { _salary = value; } }
    }
}