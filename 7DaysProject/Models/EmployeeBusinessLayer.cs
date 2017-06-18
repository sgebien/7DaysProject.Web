using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7DaysProject.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployees()
        {
            List<Employee> emyployees=new List<Employee>();
            Employee emp = new Employee();
            emp.Firstname = "Johnson";
            emp.Lastname = "fernandes";
            emp.Salary = 14000;
            emyployees.Add(emp);

            emp = new Employee();
            emp.Firstname = "Michael";
            emp.Lastname = "Jackson";
            emp.Salary = 16000;
            emyployees.Add(emp);

            emp = new Employee();
            emp.Firstname = "Robert";
            emp.Lastname = "Pattinson";
            emp.Salary = 20000;
            emyployees.Add(emp);

            return emyployees;
        }
    }
}