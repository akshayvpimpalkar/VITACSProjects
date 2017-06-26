using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmployeeMVC.Models;

namespace EmployeeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Detail() {

            Employee e = new Employee()
            {
                Id = 101,
                Name = "Akshay",
                Gender = "male",
                Salary = 50000
            };
            return View(e);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                return View("Detail_d", e);
            }
        }
    }
}