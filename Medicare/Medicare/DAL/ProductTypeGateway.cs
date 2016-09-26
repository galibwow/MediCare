using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Medicare.Models;

namespace Medicare.DAL
{
    public class ProductTypeGateway
    {
        private string connectionString =
         WebConfigurationManager.ConnectionStrings["MedicareDbContext"].ConnectionString;
        public bool IsNameExist(ProductType productType)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string quary = "Select * from  Where ProductTypeName='" + productType.ProductTypeName + "'";
            SqlCommand command = new SqlCommand(quary, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                reader.Read();
                ProductType pro=new ProductType();
                
                pro.ProductTypeName = reader["ProductTypeName"].ToString();

                connection.Close();
                reader.Close();
                return true;

            }
            return false;
        }
    }
}