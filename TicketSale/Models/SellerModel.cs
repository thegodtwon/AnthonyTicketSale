using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TicketSale.Models
{
    public class SellerModel
    {
        public int SellerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}