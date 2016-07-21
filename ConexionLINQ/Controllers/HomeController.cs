using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConexionLINQ.Models;

namespace ConexionLINQ.Controllers
{
    public class HomeController : Controller
    {
        // Mostrar en el Index todos los Pepinos existentes 
        // http://www.asp.net/mvc/overview/older-versions-1/models-data/creating-model-classes-with-linq-to-sql-cs
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
    }
}