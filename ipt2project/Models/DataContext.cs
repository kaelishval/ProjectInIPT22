using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MySql.Data.EntityFramework;

namespace ipt2project.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DefaultConnection")
        {
            this.Configuration.ValidateOnSaveEnabled = false;
        }

        //Your model classes should be added as DbSets
        public DbSet<Order> Orders { get; set; }

        public DbSet<History> Historys { get; set; }
        public DbSet<Products> Product { get; set; }

    }
}