﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberManagementSystem.Models;

namespace MemberManagementSystem.Controllers
{
    public class EditController : Controller
    {
        private readonly NorthwindEntities _db = new NorthwindEntities();

        //Get
        public PartialViewResult Edit(int id)
        {
            var employeeInfo = _db.Employees.FirstOrDefault(x => x.EmployeeID == id);

            return PartialView("_EditPartial", employeeInfo);
        }

        [HttpPost]
        public ActionResult Edit(Employees employeeNewInfo)
        {
            _db.Entry(employeeNewInfo).State = EntityState.Modified;

            //var editEmployee = _db.Employees.FirstOrDefault(x => x.EmployeeID == employeeId);
            //editEmployee.Name = employeeNewInfo.Name;
            //editEmployee.Age = employeeNewInfo.Age;
            //editEmployee.Address = employeeNewInfo.Address;
            //editEmployee.Tel = employeeNewInfo.Tel;
            _db.SaveChanges();
            return RedirectToAction("Index", "List");
        }
    }
}