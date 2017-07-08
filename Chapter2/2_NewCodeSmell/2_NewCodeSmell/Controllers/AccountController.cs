using SecurityServiceInterfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRepositoryInterfaces.Controllers
{
    public class AccountController : Controller
    {
        private readonly ISecurityService securityService;

        public AccountController(ISecurityService securityService) {
            if (securityService == null) throw new ArgumentNullException("securityService");
            this.securityService = securityService;
        }

        [HttpGet]
        public ActionResult ChangePassword() {
            return View();
        }


        [HttpPost]
        public ActionResult ChangePassword(int userId, string newPassword)
        {
            securityService.ChangePassword(userId, newPassword);
            return View();
        }
    }
}