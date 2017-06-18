using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _7DaysProject.ViewModels
{
    public class EmployeeListViewModel
    {
        public List<EmployeeViewModel> Employees { get; set; }
        public string Username { get; set; }    
    }
}