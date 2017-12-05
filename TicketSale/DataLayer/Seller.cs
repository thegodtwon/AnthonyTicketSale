using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using TicketSale.Models;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TicketSale.DataLayer
{
    public class Seller
    {
        public static void Create(SellerModel sellername)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TicketSaleConn"].ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = string.Format("INSERT INTO Seller (LastName, FirstName) VALUES ('{0}', '{1}')", sellername.LastName, sellername.FirstName, DateTime.UtcNow);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}