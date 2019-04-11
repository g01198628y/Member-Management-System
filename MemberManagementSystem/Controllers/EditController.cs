using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberManagementSystem.Models;

namespace MemberManagementSystem.Controllers
{
    public class EditController : Controller
    {
        // GET: Edit
        public PartialViewResult Edit(int id)
        {
            var _db = new NorthwindEntities();
            var editEmployee = _db.Employees.FirstOrDefault(x => x.EmployeeID == id);

            return PartialView("_EditPartial", editEmployee);
        }
    }
}