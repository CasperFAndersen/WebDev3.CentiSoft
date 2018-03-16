using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDev3.CentiSoft.Core.Contracts;
using WebDev3.CentiSoft.Core.Models;

namespace CentiSoftWeb.Controllers
{
    public class DeveloperController : Controller
    {
        private IDeveloperFacade developerFacade;
        public DeveloperController(IDeveloperFacade developerFacade)
        {
            this.developerFacade = developerFacade;
        }
        // GET: Developer
        public ActionResult Index()
        {
            //Repository<Developer> developerRepository = new Repository<Developer>();
            //IEnumerable<Developer> allDevelopers = developerRepository.GetAll();
            return View();
        }

        public ActionResult Save()
        {
            //create a developer
            Developer d = new Developer();
            developerFacade.SaveDeveloper(d);
            return View();
        }

        public ActionResult Load()
        {
            return View();
        }


    }
}