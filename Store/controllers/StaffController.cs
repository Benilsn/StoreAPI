using System;
using Store.controllers.icontroller;
using Store.entities;
using System.Collections.Generic;
using System.Data.SqlClient;
using Store.database;
using Store.entities.Enum;

namespace Store.controllers
{
    public class StaffController : IController<Staff>
    {

        DataBase db = new DataBase();
        public void deleteById(long id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "DELETE FROM Staff WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    db.Connect();
                    cmd.ExecuteReader();
                }catch(SqlException e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    db.Disconnect(db.getConnection);
                }
            }
        }

        public List<Staff> getAll()
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Staff";
                cmd.Connection = db.getConnection;
                db.Connect();

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        List<Staff> list = new List<Staff>();

                        while (dr.Read())
                        {
                            Staff s = new Staff();

                            s.Name = dr.GetString(dr.GetOrdinal("Name"));
                            s.Age = dr.GetInt32(dr.GetOrdinal("Age"));
                            s.Role = dr.GetString(dr.GetOrdinal("Role"));
                            s.Entry_Date = dr.GetDateTime(dr.GetOrdinal("EntryDate"));
                            var field = (string)dr["Department"];
                            s.Department = (Department)Enum.Parse(typeof(Department), field);
                            list.Add(s);
                                                     
                        }
                        db.Disconnect(db.getConnection);
                        return list; 
                    }
                }
            }
            return null;
            db.Disconnect(db.getConnection);
        }

        public long getByName(string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT Id FROM Staff WHERE Name = @name";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@name", name);
                db.Connect();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();

                        long ident = dr.GetInt32(dr.GetOrdinal("Id"));
                        db.Disconnect(db.getConnection);
                        return ident;
                    }
                }
                db.Disconnect(db.getConnection);
                return 0;
            }
        }

        public Staff getById(long id)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "SELECT * FROM Staff WHERE Id = @id";
                    cmd.Connection = db.getConnection;
                    cmd.Parameters.AddWithValue("@id", id);
                    db.Connect();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            Staff s = new Staff();
                            dr.Read();

                            s.Name = dr.GetString(dr.GetOrdinal("Name"));
                            s.Age = dr.GetInt32(dr.GetOrdinal("Age"));
                            s.Role = dr.GetString(dr.GetOrdinal("Role"));
                            s.Entry_Date = dr.GetDateTime(dr.GetOrdinal("EntryDate"));
                            var field = (string)dr["Department"];
                            s.Department = (Department)Enum.Parse(typeof(Department), field);

                            db.Disconnect(db.getConnection);
                            return s;
                        }
                    }
                    db.Disconnect(db.getConnection);
                    return null;
                }
            }
            catch (NullReferenceException)
            {
                return null;
                throw;               
            }
        }

        public void insert(Staff o)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Staff (Name, Age, Role, EntryDate, Department)" +
                                  "VALUES (@name, @age, @role, @entrydate, @department)";

                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@name", o.Name);
                cmd.Parameters.AddWithValue("@age", o.Age);
                cmd.Parameters.AddWithValue("@role", o.Role);
                cmd.Parameters.AddWithValue("@entrydate", o.Entry_Date);
                cmd.Parameters.AddWithValue("@department", o.Department);

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

        public void updateAll(long id, Staff o)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET Name = @name, Age = @age, Role = @role, EntryDate = @entrydate, Department = @department WHERE Id = @id";
                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", o.Name);
                cmd.Parameters.AddWithValue("@age", o.Age);
                cmd.Parameters.AddWithValue("@role", o.Role);
                cmd.Parameters.AddWithValue("@entrydate", o.Entry_Date);
                cmd.Parameters.AddWithValue("@department", o.Department);
                db.Connect();

                try
                {
                    cmd.ExecuteNonQuery();
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

        public void updateName(long id, string name)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET Name = @name WHERE Id = @id";
                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                db.Connect();

                try
                {
                    cmd.ExecuteNonQuery();
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

        public void updateAge(long id, int age) 
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET Age = @age WHERE Id = @id";
                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@age", age);
                db.Connect();

                try
                {
                    cmd.ExecuteNonQuery();
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

        public void updateRole(long id, string role) 
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET Role = @role WHERE Id = @id";
                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@role", role);
                db.Connect();

                try
                {
                    cmd.ExecuteNonQuery();
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
        public void updateEntryDate(long id, DateTime entrydate) 
        { 
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET EntryDate = @entrydate WHERE Id = @id";
                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@entrydate", entrydate);
                db.Connect();

                try
                {
                    cmd.ExecuteNonQuery();
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

        public void updateDepartment(long id, Department department) 
        { 
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Staff SET Department = @department WHERE Id = @id";
                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@department", department);
                db.Connect();

                try
                {
                    cmd.ExecuteNonQuery();
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
