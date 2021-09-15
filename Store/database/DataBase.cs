using System;
using System.Data.SqlClient;

namespace Store.database
{
    public class DataBase 
    {

        private SqlConnection con = new SqlConnection("Data Source=MACHINE;Initial Catalog=Stor;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public SqlConnection getConnection
        {
            get { return con; }
        }

        public void Connect()
        {
            try
            {
                con.Open();

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Disconnect(SqlConnection con)
        {
            try
            {
                if (con != null)
                {
                    con.Close();
                }
                else
                {
                    Console.WriteLine("Connection Already closed!");
                }
            }
            catch(SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        
    }
}
