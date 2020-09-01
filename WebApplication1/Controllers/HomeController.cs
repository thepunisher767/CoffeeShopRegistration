using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "SWEET SWEET COFFEE!!!!!";

            return View();
        }

        public ActionResult Registration()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ThankYou(string firstname, string lastname, string email, string password)
        {
            ViewBag.Welcome = $"Welcome, {firstname} {lastname}!!";
            string userEmail = email;
            string userPassword = password;
            return View();

        }

    }
}