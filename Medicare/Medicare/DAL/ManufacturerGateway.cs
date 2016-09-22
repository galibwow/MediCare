using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Medicare.Models;

namespace Medicare.DAL
{
    public class ManufacturerGateway
    {

        private string connectionString =
            WebConfigurationManager.ConnectionStrings["MedicareDbContext"].ConnectionString;

        public bool IsNameExist(Manufacturar manufacturar)
        {
           SqlConnection connection=new SqlConnection(connectionString);

           string quary = "Select * from Manufacturar Where ManufacturarName='" + manufacturar.ManufacturarName + "'";
            SqlCommand command=new SqlCommand(quary,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                reader.Read();
                Manufacturar manu = new Manufacturar();
                //setup.Id = Convert.ToInt32(reader["Id"].ToString());
                manu.ManufacturarName = reader["ManufacturarName"].ToString();
               
                connection.Close();
                reader.Close();
                return true;

            }
            return false;
        }

    }
}