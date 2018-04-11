using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebDev3.CentiSoft.Core.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        void Save(T t);
        void Update(T t);
        void Delete(int id);
    }
}
