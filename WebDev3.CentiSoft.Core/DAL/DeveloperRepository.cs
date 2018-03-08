using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Core.DAL
{
    public class DeveloperRepository : BaseRepository
    {
        public void Save(Developer developer)
        {
            if (developer.Id > 0)
            {
                Developer existingDeveloper = Load(developer.Id);
                existingDeveloper.Email = developer.Email;
                existingDeveloper.Name = developer.Name;
            }
            else
            {
                Context.Developers.Add(developer);
            }
            Context.SaveChanges();

        }

        public Developer Load(int id)
        {
            return Context.Developers.FirstOrDefault(x => x.Id == id);
        }

        public List<Developer> LoadAll()
        {
            return Context.Developers.ToList();
        }

        public void Delete(int id)
        {
            Developer developerToDelete = Load(id);
            Context.Developers.Remove(developerToDelete);
            Context.SaveChanges();
        }
    }
}
