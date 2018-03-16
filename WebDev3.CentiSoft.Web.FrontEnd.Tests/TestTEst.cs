using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebDev3.CentiSoft.Core.BLL;
using WebDev3.CentiSoft.Core.Contracts;
using WebDev3.CentiSoft.Core.DAL;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Web.FrontEnd.Tests
{
    [TestClass]
    public class TestTEst
    {
        [TestMethod]
        public void TestDeveloperFacadeSave()
        {
            IGenericRepository<Developer> memRepository = new MemoryRepository<Developer>();
            DeveloperFacade devFacade = new DeveloperFacade(memRepository);
        }
    }
}
