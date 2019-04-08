using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberManagementSystem.Models;

namespace MemberManagementSystem.Controllers
{
    public class DeleteController : Controller
    {
        private readonly NorthwindEntities _db = new NorthwindEntities();

        // GET: Delete
        public ActionResult Delete(int id)
        {
            var deleteEmployee = _db.Employees.FirstOrDefault(x => x.EmployeeID == id);

            if (deleteEmployee != null)
            {
                _db.Employees.Remove(deleteEmployee);
                _db.SaveChanges();
            }

            return RedirectToAction("Index", "List");
        }
    }
}