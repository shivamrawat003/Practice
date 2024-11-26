using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Practice.Models;

namespace Practice.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult HTMLPage()
        {
            return View();
        }
        public ActionResult PRRequest()
        {
            return View();
        }
        public ActionResult Save(int Id, string Name, string Email, string Phonenum, int? Gender, int? Age, int? Dept, double? Salary, string Address, string Country)
        {
            AllProcs.Employee_Data(Id, Name, Email, Phonenum, Gender, Age, Dept, Salary, Address, Country);
            return RedirectToAction("Edit");
        }
        public ActionResult Submit( string Name, string Email, string Phonenum, int? Gender, int? Age, int? Dept, double? Salary, string Address, string Country)
        {
            AllProcs.Submit_EmployeeData( Name, Email, Phonenum, Gender, Age, Dept, Salary, Address, Country);
            return RedirectToAction("HTMLPage");
        }


        public ActionResult Detail(int? id)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult Edit(int? id)
        {
            ViewBag.Id = id;
            return View();
        }
        public ActionResult Delete(int? id)
        {
            ViewBag.Id = id;
            return View();
        }

        
        public ActionResult DeleteConfirm(int Id)
        {
            AllProcs.Delete_Employee(Id);
            return RedirectToAction("Delete");
            
        }
    }
}