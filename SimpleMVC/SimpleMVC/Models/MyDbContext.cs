using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleMVC.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("name=cns")
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}