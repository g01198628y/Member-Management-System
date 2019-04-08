using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberManagementSystem.Models;

namespace MemberManagementSystem.Controllers
{
    public class ListController : Controller
    {
        private readonly NorthwindEntities _db = new NorthwindEntities();

        public ActionResult Index()
        {
            var employeeList = _db.Employees.OrderBy(x => x.EmployeeID).ToList();
            return View(employeeList);
        }
    }
}