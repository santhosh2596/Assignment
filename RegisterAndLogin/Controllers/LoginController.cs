using RegisterAndLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Security;

using HttpGetAttribute = System.Web.Http.HttpGetAttribute;

namespace RegisterAndLogin.Controllers
{
    public class LoginController : Controller
    {
              // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        

        [HttpGet]
        public ActionResult ValidateUser()
        {
            if (GetValidUser())
            {
                return View();
            }
            else
            {
                return View("ValidateUserFailed");
            }
        }

       
        [HttpGet]
        
        public bool GetValidUser()
        {
            var creds = new Login();
            var returvalues = creds.ValidateUser("Santhosh", "test124");
            if (returvalues != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}