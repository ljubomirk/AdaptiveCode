using _2_NewCodeSmell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2_NewCodeSmell.Controllers
{
    public class AccountController : Controller
    {
        private readonly SecurityService securityService;

        public AccountController() {
            this.securityService = new SecurityService();
        }

        [HttpGet]
        public ActionResult ChangePassword() {
            return View();
        }


        [HttpPost]
        public ActionResult ChangePassword(int userId, string newPassword)
        {
            return View();
        }
    }
}