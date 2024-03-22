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
        public ViewResult Login(FormCollection values)
        {
            return View();
        }
    }
}