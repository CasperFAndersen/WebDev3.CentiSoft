using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebDev3.CentiSoft.Core.Contracts;

namespace WebDev3.CentiSoft.Core.DAL
{
    public class EFRepository<T> : IGenericRepository<T> where T : class
    {
        private CentiSoftDbContext context;
        private IDbSet<T> dbSet;

        public EFRepository(CentiSoftDbContext context)
        {
            context = new CentiSoftDbContext();
            dbSet = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return this.dbSet.ToList();
        }

        public virtual T GetByID(int id)
        {
            return dbSet.Find(id);
        }

        //public virtual IEnumerable<T> Get(
        //   Expression<Func<T, bool>> filter = null,
        //   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
        //   string includeProperties = "")
        //{
        //    IQueryable<T> query = dbSet;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    foreach (var includeProperty in includeProperties.Split
        //        (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    {
        //        query = query.Include(includeProperty);
        //    }

        //    if (orderBy != null)
        //    {
        //        return orderBy(query).ToList();
        //    }
        //    else
        //    {
        //        return query.ToList();
        //    }
        //}

        public void Save(T t)
        {
            DbEntityEntry entry = this.context.Entry(t);
            if (entry.State != System.Data.Entity.EntityState.Detached)
            {
                entry.State = System.Data.Entity.EntityState.Added;
            }
            else
            {
                this.dbSet.Add(t);
            }
            //this.context.SaveChanges();
        }

        public void Update(T t)
        {
            DbEntityEntry entry = this.context.Entry(t);
            if (entry.State == EntityState.Detached)
            {
                this.dbSet.Attach(t);
            }
            entry.State = EntityState.Modified;
            //context.SaveChanges();
        }
        public void Delete(int id)
        {
            T t = GetByID(id);
            DbEntityEntry entry = this.context.Entry(t);
            if (entry.State != EntityState.Deleted )
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.dbSet.Attach(t);
                this.dbSet.Remove(t);
            }
            //this.context.SaveChanges();
        }
    }
}
