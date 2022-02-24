using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookPediaApi.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        
        }
        public DbSet<Book> books { get; set; } // My domain models
        public DbSet<User> users { get; set; }// My domain models
        public DbSet<Inventory> inventory { get; set; }// My domain models

    }
}