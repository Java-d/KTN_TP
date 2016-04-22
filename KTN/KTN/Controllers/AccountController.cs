using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using KTN.KTNServiceRef;
using KTN.Models;
using KTN.Security;

namespace KTN.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            if (Session["IsAuth"] != null && (bool)Session["IsAuth"])
            {
                return LogOut();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                KTNServiceClient client = new KTNServiceClient();
                UserDto user = client.GetUser(model.UserName, model.Password);
                client.Close();
                if(user !=null)
                {
                    Session["User"] = user;
                    Session["IsAuth"] = true;
                    return Redirect("/Home/Persons");
                }
                else
                {
                    ModelState.AddModelError("", "Yalnış istifadəçi adı və ya şifrə");
                    return View(model);
                }
                
            }

            return View(model);
        }

        [HttpPost]
        [LoggedInFilter]
        public ActionResult LogOut()
        {
            Session["User"] = null;
            Session["IsAuth"] = false;
            return RedirectToAction("Login", "Account", null);
        }
    }
}