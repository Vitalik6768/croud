using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace croudc.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Personal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Personal(string sname, string contact, string adress) { 
            if(sname == "" || contact=="" || adress=="")
            {
                ViewBag.msg = "Please Enter All Info";
                return View();
            }
            else
            {
                TempData["sname"] = sname;
                TempData["adress"] = adress;
                TempData["contact"] = contact;

                return RedirectToAction("marks");

            }
        }
        public ViewResult Marks()
        {
            return View();
        }

        [HttpPost]
            public ActionResult Marks(int theory = 0, int pracs = 0, int oral = 0)
        {
            if (theory < 0 || theory > 100 || pracs < 0 || pracs > 100 || oral < 0 || oral > 100)
            {
                ViewData["msg"] = "invalid marks";
                return View();

            }
            else
            {
                TempData["theory"] = theory;
                TempData["pracs"] = pracs;
                TempData["oral"] = oral;

                return RedirectToAction("DisplayResult");

            }
                
        }

        public ViewResult DisplayResult()
        {
            return View();
        }


    }
}