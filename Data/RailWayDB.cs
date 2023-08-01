using Microsoft.EntityFrameworkCore;
using RailWayWpfApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayWpfApp.Data
{
    class RailWayDB : DbContext
    {
        public DbSet<Login> Logins { get; set; }

        public DbSet<RailWayTable> RailWayTables { get; set; }

        public DbSet<Registratsiya> Registratsiyas { get; set; }


        private string stringConnection = "Server = localhost;" +
            "Port = 5432;" +
            "User Id = postgres;" +
            "Database = RailWayDb;" +
            "Password = salom";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(stringConnection);
        }


    }
}
