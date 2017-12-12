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
    public class Event
    {
        public static void Create(EventModel eventname)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TicketSaleConn"].ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = string.Format("INSERT INTO Event (EventName, EventNameDate) VALUES ('{0}', '{1}')", eventname.EventName, DateTime.UtcNow);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sql Error: {0}", ex.Message);
            }
        }
    }
}