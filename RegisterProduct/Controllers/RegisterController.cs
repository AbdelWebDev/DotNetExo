using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RegisterProduct.Models;

namespace RegisterProduct.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult SubmitRegisterProoduct(Produit produit)
        {
            return View(produit);
        }
    }
}