using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDev3.CentiSoft.Core.DAL;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Web.FrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Brian showing on the board.

            //CentiSoftDbContext myContext = new CentiSoftDbContext();
            //Developer mydeveloper = new Developer();
            //mydeveloper.Name = "peter";
            //mydeveloper.Email = "hello@hello.dk";
            //myContext.Developers.Add(mydeveloper);
            //myContext.SaveChanges();

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

        public ActionResult test()
        {
            return View();
        }
    }
}