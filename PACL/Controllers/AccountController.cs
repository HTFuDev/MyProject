using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PACL.ViewModels.ViewModels;
using PACL.ServiceLayer.Services;
using PACL.ServiceLayer.ServiceModels;
using PACL.ServiceLayer.MapperExtension;

namespace PACL.Controllers
{
    public class AccountController : Controller
    {

        IRegistrationService reg;

        public AccountController(IRegistrationService reg)
        {
            this.reg = reg;
        }

        // GET: Account
        public ActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Register(RegistrationViewModel registrationViewModel)
        {
            if (ModelState.IsValid)
            {
                this.reg.NewRegistration(registrationViewModel);
                return RedirectToAction("Index", "Home");
            }
            else {
                ModelState.AddModelError("x", "Invalid data");
                return View();
            }
        }
    }
}