
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZimmerArcitect.core.Models;

namespace ZimmerArcitect.Data
{
    public class DataContext:DbContext
    {
       public DbSet<User> DataUser {  get; set; }
       public DbSet<Zimmer>DataZimmers { get; set; }
       public DbSet<Order> DataOrders { get; set; }
       public DbSet<Owner> DataOwners { get; set; }
       public DbSet<Cleaner> DataCleaners { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Zimmer_db");
        }

    }
}

