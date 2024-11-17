using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Data
{
    internal class Sql
    {
        private const string ConnectionString = @"server=LAPTOP-04DP7Q7I\SQLEXPRESS;database=Students;trusted_connection=true;integrated security=true;TrustServerCertificate=true";
        private static SqlConnection Connection = new SqlConnection(ConnectionString);

        public int ExecuteCommnad(string command)
        {
            int result;
            try
            {
                Connection.Open();
                SqlCommand cmd = new SqlCommand(command, Connection);
                result = cmd.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;

            }
            finally {
            
                Connection.Close();
            }
          
            
            return result;
            
        }

        public DataTable ExecuteQuery(string query)
        {
            DataTable table = new DataTable();
            try
            {
                Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, Connection);
                adapter.Fill(table);
            }

            catch (Exception)
            { 
                throw;
            }

            finally
            { 
                Connection.Close();
            }

            return table;
        }
    }
}
