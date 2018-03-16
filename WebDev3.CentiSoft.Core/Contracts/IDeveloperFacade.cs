using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Core.Contracts
{
    public interface IDeveloperFacade
    {
        void SaveDeveloper(Developer developer);
    }
}
