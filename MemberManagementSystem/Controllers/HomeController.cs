using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberManagementSystem.Models;

namespace MemberManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            NorthwindEntities db = new NorthwindEntities();
            var employeeList = db.Employees.OrderBy(x => x.EmployeeID).ToList();
            return View(employeeList);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}