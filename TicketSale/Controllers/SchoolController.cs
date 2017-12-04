using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSale.Models;
using TicketSale.DataLayer;

namespace TicketSale.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // POST: School
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SchoolVM school)
        {
            School.Create(school);
            return View(school);
        }
    }
}