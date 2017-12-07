namespace SimpleMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SimpleMVC.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SimpleMVC.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Books.Add(new Models.Book() { isbn = "111111", title = "Aaaaaa" });
            context.Books.Add(new Models.Book() { isbn = "222222", title = "Bcccc" });
            context.Books.Add(new Models.Book() { isbn = "333333", title = "Dsdsds" });
            context.Books.Add(new Models.Book() { isbn = "677777", title = "Asdfghj" });
            context.Books.Add(new Models.Book() { isbn = "234567", title = "Werty" });
            context.SaveChanges();
        }
    }
}
