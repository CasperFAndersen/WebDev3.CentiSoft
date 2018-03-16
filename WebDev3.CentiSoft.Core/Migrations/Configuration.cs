namespace WebDev3.CentiSoft.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebDev3.CentiSoft.Core.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebDev3.CentiSoft.Core.DAL.CentiSoftDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebDev3.CentiSoft.Core.DAL.CentiSoftDbContext";
        }

        protected override void Seed(WebDev3.CentiSoft.Core.DAL.CentiSoftDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.


            //Developers
            context.Developers.AddOrUpdate(x => x.Id,
                new Developer() { Id = 1, Name = "First dev1", Email = "First@dev.dk" },
                new Developer() { Id = 2, Name = "Second dev2", Email = "Second@dev.dk" },
                new Developer() { Id = 3, Name = "Third dev3", Email = "Third@dev.dk" },
                new Developer() { Id = 4, Name = "Fourth dev4", Email = "Fourth@dev.dk" },
                new Developer() { Id = 5, Name = "Fifth dev5", Email = "Fifth@dev.dk" }
                );
            //Customers
            context.Customers.AddOrUpdate(x => x.Id,
                new Customer() { Id = 1, Name = "First Cus1", Address = "AddressCus1", Address1 = "Adress2Cus1", Zip = 1000, City = "CityCus1", Country = "CountryCus1", Email = "EmailCus1", Phone = "PhoneCus1", ClientId = 1 },
                new Customer() { Id = 2, Name = "Second Cus2", Address = "AddressCus2", Address1 = "Adress2Cus2", Zip = 2000, City = "CityCus2", Country = "CountryCus2", Email = "EmailCus2", Phone = "PhoneCus2", ClientId = 2 },
                new Customer() { Id = 3, Name = "Third Cus3", Address = "AddressCus3", Address1 = "Adress2Cus3", Zip = 3000, City = "CityCus3", Country = "CountryCus3", Email = "EmailCus3", Phone = "PhoneCus3", ClientId = 3 },
                new Customer() { Id = 4, Name = "Fourth Cus4", Address = "AddressCus4", Address1 = "Adress2Cus4", Zip = 4000, City = "CityCus4", Country = "CountryCus4", Email = "EmailCus4", Phone = "PhoneCus4", ClientId = 4 },
                new Customer() { Id = 5, Name = "Fifth Cus5", Address = "AddressCus5", Address1 = "Adress2Cus5", Zip = 5000, City = "CityCus5", Country = "CountryCus5", Email = "EmailCus5", Phone = "PhoneCus5", ClientId = 5 }
                );
            //Clients
            context.Clients.AddOrUpdate(x => x.Id,
                new Client() { Id = 1, Name = "client1 name", Token = "xxxToken1" },
                new Client() { Id = 2, Name = "client2 name", Token = "xxxToken2" },
                new Client() { Id = 3, Name = "client3 name", Token = "xxxToken3" },
                new Client() { Id = 4, Name = "client4 name", Token = "xxxToken4" },
                new Client() { Id = 5, Name = "client5 name", Token = "xxxToken5" }
                );
            //Tasks
            //context.Tasks.AddOrUpdate(x => x.Id,
            //    new Task() { Id = 1, Name = "Task1 name", Description = "Task1 description", Created = DateTime.Now, Duration = 10, ProjectId = 1, Project givprojeckther, DeveloperId = 1, Developer = devloperher },
            //    new Task() { Id = 2, Name = "Task2 name", Description = "Task2 description", Created = DateTime.Now, Duration = 20, ProjectId = 2, Project givprojeckther, DeveloperId = 2, Developer = devloperher },
            //    new Task() { Id = 3, Name = "Task3 name", Description = "Task3 description", Created = DateTime.Now, Duration = 30, ProjectId = 3, Project givprojeckther, DeveloperId = 3, Developer = devloperher },
            //    new Task() { Id = 4, Name = "Task4 name", Description = "Task4 description", Created = DateTime.Now, Duration = 40, ProjectId = 4, Project givprojeckther, DeveloperId = 4, Developer = devloperher },
            //    new Task() { Id = 5, Name = "Task5 name", Description = "Task5 description", Created = DateTime.Now, Duration = 50, ProjectId = 5, Project givprojeckther, DeveloperId = 5, Developer = devloperher }
            //    );
            //Projects
            //context.Projects.AddOrUpdate(x => x.Id,
            //    new Project() { Id = 1, Name = "Project1 name", DueDate = DateTime.Now, CustomerId = 1, Tasks = },
            //    new Project() { Id = 1, Name = "Project2 name", DueDate = DateTime.Now, CustomerId = 1, Tasks = },
            //    new Project() { Id = 1, Name = "Project3 name", DueDate = DateTime.Now, CustomerId = 1, Tasks = },
            //    new Project() { Id = 1, Name = "Project4 name", DueDate = DateTime.Now, CustomerId = 1, Tasks = },
            //    new Project() { Id = 1, Name = "Project5 name", DueDate = DateTime.Now, CustomerId = 1, Tasks = }
            //    );

        }


    }
}
