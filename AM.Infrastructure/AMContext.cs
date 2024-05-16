
using AM.ApplicationCore.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AM.Infrastructure
{
    public class AMContext: DbContext
    {



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
              Initial Catalog=AirportManagementDB;Integrated Security=true");
            base.OnConfiguring(optionsBuilder);
        }
        //public AMContext(DbContextOptions<AMContext> options) : base(options)
        //{

        //}

        public AMContext()
        {
            //this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public AMContext(DbContextOptions<AMContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
        
        }



    }
}
