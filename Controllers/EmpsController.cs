using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practice.Controllers
{
    public class EmpsController : Controller
    {
        // GET: Emps
        public ActionResult Index()
        {
            return View();
        }

        

        //Create Save Function

        public ActionResult Details(int? id)
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
        //Edit View Page -- ActionResult
        //Edit Save Function -- function

        //Delete View Page -- ActionResult
        //Function to Delete
    }
}