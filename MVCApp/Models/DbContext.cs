using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }


        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Logs> Logs { get; set; }


        public DbSet<Customer> Customers { get; set; }
        public MyDbContext() : base("name=MvcAppDb") 
        {
             
        }
    }
}