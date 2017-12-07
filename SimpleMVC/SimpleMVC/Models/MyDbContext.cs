using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleMVC.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base(@"Data Source=localhost\sqlexpress;Initial Catalog=TestDB;Persist Security Info=True;User ID=sa;Password=root")
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }

    }
}