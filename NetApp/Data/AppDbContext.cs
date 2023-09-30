using NetApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetApp
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DbConnectionString")
        {
            
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Song> Songs { get; set; }
    }
}
