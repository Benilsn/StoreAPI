using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Store.controllers.icontroller;
using Store.database;
using Store.entities;

namespace Store.controllers
{
    public class ClientController : IController<Client>
    {

        DataBase db = new DataBase();


        public void insert(Client o)
        {
            using (SqlCommand cmd = new SqlCommand())
            {

                cmd.CommandText = "INSERT INTO Client (Name, Age, MemberSince, Phone) " +
                                    "VALUES (@name, @age, @membersince, @phone)";

                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@name", o.Name);
                cmd.Parameters.AddWithValue("@age", o.Age);
                cmd.Parameters.AddWithValue("@membersince", o.Date);
                cmd.Parameters.AddWithValue("@phone", o.Phone);

                try
                {
                    if (db.getConnection != null)
                    {
                        db.Connect();
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Failed adding in database!");
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }
            }
        }

        public Client getById(long id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Client WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                db.Connect();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        Client c = new Client();
                        dr.Read();
                        c.Name = dr.GetString(dr.GetOrdinal("Name"));
                        c.Age = dr.GetInt32(dr.GetOrdinal("Age"));
                        c.Date = dr.GetDateTime(dr.GetOrdinal("MemberSince"));
                        c.Phone = dr.GetString(dr.GetOrdinal("Phone"));
                        return c;
                    }

                }
            }
            db.Disconnect(db.getConnection);
            return null;
        }

        public List<Client> getAll()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Client";
                cmd.Connection = db.getConnection;
                db.Connect();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        List<Client> list = new List<Client>();

                        while (dr.Read())
                        {
                            Client c = new Client();

                            c.Name = dr.GetString(dr.GetOrdinal("Name"));
                            c.Age = dr.GetInt32(dr.GetOrdinal("Age"));
                            c.Date = dr.GetDateTime(dr.GetOrdinal("MemberSince"));
                            c.Phone = dr.GetString(dr.GetOrdinal("Phone"));
                            list.Add(c);
                        }
                        db.Disconnect(db.getConnection);
                        return list;
                    }
                }
            }
            db.Disconnect(db.getConnection);
            return null;
        }

        public void deleteById(long id)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "DELETE FROM Client WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                
                try
                {
                    db.Connect();
                    cmd.ExecuteReader();
                }
                catch(SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }
            }
        } 

        public void updateName(long id, string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Client SET Name = @name   WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                db.Connect();

                try
                {
                    cmd.ExecuteReader();
                }
                catch(SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }

            }
        }

        public void updateAge(long id, int age)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Client SET Age = @age   WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@age", age);
                db.Connect();

                try
                {
                    cmd.ExecuteReader();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }

            }
        }

        public void updateDate(long id, DateTime date)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Client SET MemberSince = @date   WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@date", date);
                db.Connect();

                try
                {
                    cmd.ExecuteReader();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }

            }
        }

        public void updatePhone(long id, string phone)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Client SET Phone = @phone   WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@phone", phone);
                db.Connect();

                try
                {
                    cmd.ExecuteReader();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }

            }
        }

        public void updateAll(long id, Client c)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Client SET Name = @name, Age = @age, MemberSince = @date, Phone = @phone WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", c.Name);
                cmd.Parameters.AddWithValue("@Age", c.Age);
                cmd.Parameters.AddWithValue("@date", c.Date);
                cmd.Parameters.AddWithValue("@Phone", c.Phone);
                db.Connect();

                try
                {
                    cmd.ExecuteReader();
                }
                catch (SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }

            }
        }

        
    }
}
