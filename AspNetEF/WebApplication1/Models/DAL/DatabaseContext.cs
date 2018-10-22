using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.DAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            // base.OnModelCreating(modelBuilder);
            //пусть будет users!
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>(); 

        }
    }

    public class DataBaseInitializer : DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        protected override void Seed(DatabaseContext context)
        {
            

            context.Users.Add(
                new User()
                {
                    Email = "test@mail.ru",
                    Password = "1234"
                }
                );
            context.SaveChanges();
            //base.Seed(context);
        }
    }
}