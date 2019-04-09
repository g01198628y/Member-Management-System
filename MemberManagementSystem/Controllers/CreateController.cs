using MemberManagementSystem.Models;
using System;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace MemberManagementSystem.Controllers
{
    public class CreateController : Controller
    {
        // GET: Create
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employees employees)
        {
            if (ModelState.IsValid)
            {
                var db = new NorthwindEntities();
                var newEmployee = new Employees { Name = employees.Name, Age = employees.Age, Address = employees.Address, Tel = employees.Tel };
                db.Employees.Add(newEmployee);
                db.SaveChanges();
                return RedirectToAction("Index", "List");
            }

            var validateError = new Employees { createValidateError = ModelState };

            return View("Index", validateError);
        }
    }
}