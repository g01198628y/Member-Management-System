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
        private readonly NorthwindEntities _db = new NorthwindEntities();

        public ActionResult Index()
        {
            var employeeList = _db.Employees.OrderBy(x => x.EmployeeID).ToList();
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

        public ActionResult Delete(int id)
        {
            var deleteEmployee = _db.Employees.FirstOrDefault(x => x.EmployeeID == id);

            if (deleteEmployee != null)
            {
                _db.Employees.Remove(deleteEmployee);
                _db.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}