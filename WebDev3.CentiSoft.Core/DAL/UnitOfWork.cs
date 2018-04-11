using System;
using WebDev3.CentiSoft.Core.DAL;
using WebDev3.CentiSoft.Core.Models;

namespace ContosoUniversity.DAL
{
    public class UnitOfWork : IDisposable
    {
        private CentiSoftDbContext context = new CentiSoftDbContext();

        private EFRepository<Client> clientRepository;
        private EFRepository<Customer> customerRepository;
        private EFRepository<Developer> developerRepository;
        private EFRepository<Project> projectRepository;
        private EFRepository<Task> taskRepository;

        public EFRepository<Client> DepartmentRepository
        {
            get
            {

                if (this.clientRepository == null)
                {
                    this.clientRepository = new EFRepository<Client>(context);
                }
                return clientRepository;
            }
        }

        public EFRepository<Customer> CustomerRepository
        {
            get
            {

                if (this.customerRepository == null)
                {
                    this.customerRepository = new EFRepository<Customer>(context);
                }
                return customerRepository;
            }
        }
        public EFRepository<Developer> DeveloperRepository
        {
            get
            {

                if (this.developerRepository == null)
                {
                    this.developerRepository = new EFRepository<Developer>(context);
                }
                return developerRepository;
            }
        }
        public EFRepository<Project> ProjectRepository
        {
            get
            {

                if (this.projectRepository == null)
                {
                    this.projectRepository = new EFRepository<Project>(context);
                }
                return projectRepository;
            }
        }
        public EFRepository<Task> TaskRepository
        {
            get
            {

                if (this.taskRepository == null)
                {
                    this.taskRepository = new EFRepository<Task>(context);
                }
                return taskRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}