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
    public class SellerController : Controller
    {

        //private Seller db = new Seller();

        // GET: Seller
        [HttpGet]
        public ActionResult Index(int id = 0)
        {
            //var sellers = db.Event.Where(s => s.EventID == id);
            return View();
        }
        // POST: Seller
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SellerModel NewSeller)
        {
            Seller.Create(NewSeller);
            return View(NewSeller);
        }
        
    }
}
