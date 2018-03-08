using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev3.CentiSoft.Core.DAL
{
    public class BaseRepository
    {
        protected CentiSoftDbContext Context;

        public BaseRepository()
        {
            Context = new CentiSoftDbContext();
        }
    }
}
