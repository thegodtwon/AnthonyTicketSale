using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketSale.Models;

namespace TicketSale.Controllers
{
    public class SchoolController : Controller
    {
        //private TicketSaleDb db = new TicketSaleDb();

        // GET: School
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        // POST: School
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string schoolname)
        {
            //if (ModelState.IsValid)
            //{
            //    db.SchoolName.Add(schoolname);
            //    db.SaveChanges();
            //    return RedirectToAction("Index");
            //}
            return View();
        }
    }
}