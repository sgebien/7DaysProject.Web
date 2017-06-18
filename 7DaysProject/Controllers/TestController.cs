using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Razor.Parser.SyntaxTree;
using _7DaysProject.Models;
using _7DaysProject.ViewModels;

namespace _7DaysProject.Controllers
{

 public class Customer
        {
            public string CustomerName { get; set; }
            public string Address { get; set; }

            public override string ToString()
            {
                return this.CustomerName + "|" + this.Address;
            }

       
        }
    public class TestController : Controller
    {
        public bool Some_Condition_is_Matching { get; set; }
        // GET: Test
        public Customer GetCustomer()
        {
            Customer c= new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address1";
            return c;
        }

        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.Firstname = "Sukesh";
            emp.Lastname = "Marla";
            emp.Salary = 15001;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = $"{emp.Firstname} {emp.Lastname}";
            vmEmp.Salary = emp.Salary.ToString("C");

            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }

            vmEmp.Username = "Admin";

            return View("MyView", vmEmp);
        }



        //I do want have a method which is public but not accasssable from the web
        [NonAction]
        public string SimpleMethod()
            {
                return "Hi, I am not action method";
            }

    }
}