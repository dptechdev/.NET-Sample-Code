using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using test2.Models;

namespace test2.Controllers
{
    public class EmployeesController : Controller
    {
        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                Name = "Derek",
                Occupation = "Programmer",
                YearsWithCompany = 3,
                Id = 111,
            };
            return View(employee);
        }
        
    }
}
