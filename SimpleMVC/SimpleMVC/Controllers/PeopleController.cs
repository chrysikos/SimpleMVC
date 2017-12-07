using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    [Authorize]
    public class PeopleController : Controller
    {
        public MyDbContext Context { get; private set; }

        public PeopleController()
        {
            this.Context = new MyDbContext();
        }
        // GET: People
        [ActionName("List")]
        public ActionResult Index()
        {
            List<Person> people = this.Context.Persons.ToList();
            return View("Index",people);
        }

        [HttpPost]
        public ActionResult AddPeople(Person person)
        {
            this.Context.Persons.Add(person);
            this.Context.SaveChanges();
            return RedirectToAction("List", "People");
        }

        public ActionResult Books()
        {
            List<Book> books = this.Context.Books.ToList();
            return View("Books", books);
        }
    }
}