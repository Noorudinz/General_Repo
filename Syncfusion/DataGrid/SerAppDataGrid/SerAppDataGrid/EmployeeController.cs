using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SerAppDataGrid
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        List<Employee> employee = new List<Employee>();
        [HttpGet]
        public object Get()
        {
            employee.Add(new Employee { EmployeeID = 1, FirstName = "Andrew", LastName = "Fuller", Title = "Branch Manager" });
            employee.Add(new Employee { EmployeeID = 2, FirstName = "Nancy", LastName = "Leverling", Title = "Product Manager" });
            employee.Add(new Employee { EmployeeID = 3, FirstName = "Anne", LastName = "Dodsworth", Title = "Team Lead" });
            employee.Add(new Employee { EmployeeID = 4, FirstName = "Laura", LastName = "Callahan", Title = "Product Manager" });
            employee.Add(new Employee { EmployeeID = 5, FirstName = "Michael", LastName = "Suyama", Title = "Team Lead" });
            employee.Add(new Employee { EmployeeID = 6, FirstName = "Robert", LastName = "King", Title = "Developer" });
            employee.Add(new Employee { EmployeeID = 7, FirstName = "Janet", LastName = "Peacock", Title = "Developer" });
            employee.Add(new Employee { EmployeeID = 8, FirstName = "Steven", LastName = "Buchanan", Title = "Developer" });
            employee.Add(new Employee { EmployeeID = 9, FirstName = "Margaret", LastName = "Davolio", Title = "Developer" });
            return employee;
        }       
    }

    public class Employee
    {
        public int? EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
    }
}



