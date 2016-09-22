using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Medicare.Models;

namespace Medicare.DAL
{
    public class GroupsGateway
    {


        private string connectionString =
            WebConfigurationManager.ConnectionStrings["MedicareDbContext"].ConnectionString;

        public bool IsNameExist(Groups groups)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string quary = "Select * from Groups Where GroupName='" + groups.GroupName + "'";
            SqlCommand command = new SqlCommand(quary, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.HasRows)
            {
                reader.Read();
                Groups aGroups=new Groups();

                
                aGroups.GroupName = reader["GroupName"].ToString();

                connection.Close();
                reader.Close();
                return true;

            }
            return false;
        }

    }
}