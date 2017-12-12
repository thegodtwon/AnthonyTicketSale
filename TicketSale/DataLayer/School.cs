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
    public class School
    {
        public static void Create(SchoolVM school)
        {
            try
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["TicketSaleConn"].ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandType = CommandType.Text;
                        command.CommandText = string.Format("INSERT INTO School (SchoolName, CreatedBy, CreatedDate) VALUES ('{0}', 0, '{1}')", school.SchoolName, DateTime.UtcNow);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sql Error: {0}", ex.Message);
            }
            //finally
            //{
            //    if (connection != null)
            //        connection.Close();
            //}
        }
    }
}