using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projectgithub.Data.Layers.Entities;

namespace Projectgithub.Data.Bll
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(string connectionString) : base(connectionString)
        {
            Database.CreateIfNotExists();
        }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
