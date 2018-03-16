using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDev3.CentiSoft.Core.Contracts;
using WebDev3.CentiSoft.Core.DAL;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Core.BLL
{
    public class DeveloperFacade : IDeveloperFacade
    {
        private IGenericRepository<Developer> developerRepository;
        public DeveloperFacade(IGenericRepository<Developer> developerRepository)
        {
            this.developerRepository = developerRepository;
        }

        public void SaveDeveloper(Developer d)
        {
            this.developerRepository.Save(d);
        }
    }
}
