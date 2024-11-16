using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp_mvc_Dbfirst.Models;

namespace WebApp_mvc_Dbfirst.Controllers
{
    public class HomeController : Controller
    {
        urunEntities urunliste = new urunEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Liste()
        {
            ViewBag.Message = "ÜRÜN LİSTEMİZ";

            return View(urunliste.uruntablo.ToList());
        }
    }
}