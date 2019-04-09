using MemberManagementSystem.Models;
using System;
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
        public ActionResult Create(string name, int age, string address, string tel)
        {
            var db = new NorthwindEntities();
            var newEmployee = new Employees { Name = name, Age = age, Address = address, Tel = tel };
            db.Employees.Add(newEmployee);
            db.SaveChanges();
            return RedirectToAction("Index", "List");
        }
    }
}