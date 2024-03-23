using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace croudc.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection values)
        {
            if (values["user"] == "admin" && values["pass"] == "12345")
                {
                Session["uname"] = "admin";
                return RedirectToAction("Personal", "student");
            }
            else
                ViewBag.msg = "Invalid";

            return View();
        }
    }
}