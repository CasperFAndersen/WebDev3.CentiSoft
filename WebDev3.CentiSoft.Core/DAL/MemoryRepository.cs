using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDev3.CentiSoft.Core.Contracts;

namespace WebDev3.CentiSoft.Core.DAL
{
    public class MemoryRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(int id)
        {
            Console.WriteLine("Deleting");
        }

        public T Get(object id)
        {
            Console.WriteLine("Getting");
            return null;
        }

        public IEnumerable<T> GetAll()
        {
            Console.WriteLine("Getting all");
            return null;
        }

        public void Save(T t)
        {
            Console.WriteLine("saving");
        }

        public void Update(T t)
        {
            Console.WriteLine("Updating");
        }
    }
}
