using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //[Produces("application/json")]
    [Route("api")]
    public class EmployeeController : Controller
    {
        [HttpGet]
        [Route("employee")]
        public List<Employee> GetEmployee()
        {

            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {

                EmployeeID = 101,
                EmployeeName = "Pandurang Chopade",
                Department = "IT",
                MailID = "pandurang@gmail.com",
                DOJ = DateTime.Now
            });

            employees.Add(new Employee
            {
                EmployeeID = 102,
                EmployeeName = "Rajesh Ambhure",
                Department = "Account",
                MailID = "rajesh@gmail.com",
                DOJ = DateTime.Now
            });

            employees.Add(new Employee
            {
                EmployeeID = 103,
                EmployeeName = "Sunil Ambhure",
                Department = "Finance",
                MailID = "sunil@gmail.com",
                DOJ = DateTime.Now
            });

            return employees;
        }

        [HttpGet]
        [Route("department")]
        public List<Department> GetDepartment()
        {
            List<Department> departments = new List<Department>();
            departments.Add(new Department
            {
                DepartmentID = 1,
                DepartmentName = "IT"
            });
            departments.Add(new Department
            {
                DepartmentID = 2,
                DepartmentName = "Finance"
            });
            departments.Add(new Department
            {
                DepartmentID = 3,
                DepartmentName = "Account"
            });
            return departments;
        }
    }
}