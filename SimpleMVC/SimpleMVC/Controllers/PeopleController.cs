﻿using SimpleMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleMVC.Controllers
{
    public class PeopleController : Controller
    {
        public MyDbContext Context { get; private set; }

        public PeopleController()
        {
            this.Context = new MyDbContext();
        }
        // GET: People
        public ActionResult Index()
        {
            List<Person> people = this.Context.Persons.ToList();
            return View("Index",people);
        }
    }
}