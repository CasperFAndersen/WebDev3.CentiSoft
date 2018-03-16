using StructureMap.Configuration.DSL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebDev3.CentiSoft.Core.BLL;
using WebDev3.CentiSoft.Core.Contracts;
using WebDev3.CentiSoft.Core.DAL;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Web.FrontEnd.DependencyResolution
{
    public class DIRegistry : Registry
    {
        public DIRegistry()
        {
            For<IGenericRepository<Developer>>().Use<EFRepository<Developer>>();
            For<IDeveloperFacade>().Use<DeveloperFacade > ();

        }
    }
}