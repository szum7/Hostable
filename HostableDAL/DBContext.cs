using HostableDAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HostableDAL
{
    public class DBContext : DbContext
    {
        public DbSet<ConnectionTest> ConnectionTest { get; set; }

        public DBContext() : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                //optionsBuilder.UseSqlServer(@"Server=.\;Database=Hostable;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(@"Server=tcp:hostable.database.windows.net,1433;Initial Catalog=Hostable;Persist Security Info=False;User ID=admn;Password=1host2ABLE3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ConnectionTest>().ToTable("ConnectionTest");
        //}
    }
}
