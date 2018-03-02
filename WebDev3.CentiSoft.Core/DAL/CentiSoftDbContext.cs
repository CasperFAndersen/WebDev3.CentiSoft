using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDev3.CentiSoft.Core.Models;

namespace WebDev3.CentiSoft.Core.DAL
{
    public class CentiSoftDbContext : DbContext
    {
        public CentiSoftDbContext() : base("centiSoftConnectionsString")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
        public DbSet<Client> Clients { get; set; }
    }

}

