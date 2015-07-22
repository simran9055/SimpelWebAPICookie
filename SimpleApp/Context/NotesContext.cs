using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleApp.Entities;
using SimpleApp.Mapper;

namespace SimpleApp.Context
{
    public class NotesContext : DbContext
    {
        public NotesContext() :
            base("NotesConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Notes> Notes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new NotesMapper());
            modelBuilder.Configurations.Add(new UserMapper());

            base.OnModelCreating(modelBuilder);
        }
    }
}
