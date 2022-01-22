using ErrandHandler.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrandHandler.Data
{
    internal class SqlContext : DbContext
    {

        public SqlContext()
        {

        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }
        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<Errand> Errands { get; set; }

        public virtual DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ralley\Desktop\Skola\ERRANDS\ErrandHandler\ErrandHandler\Data\DataBaseSqlEntityCoreFramework_WPF.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
