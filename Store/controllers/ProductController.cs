using Store.controllers.icontroller;
using Store.database;
using Store.entities;
using Store.entities.Enum;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Store.controllers
{
    public class ProductController : IController<Product>
    {

        DataBase db = new DataBase();

        public void deleteById(long id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "DELETE FROM Product WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    db.Connect();
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

        public List<Product> getAll()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Product";
                cmd.Connection = db.getConnection;

                db.Connect();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        List<Product> list = new List<Product>();

                        while (dr.Read())
                        {
                            Product p = new Product();

                            p.Name = dr.GetString(dr.GetOrdinal("Name"));
                            p.Price = dr.GetDouble(dr.GetOrdinal("Price"));
                            p.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"));
                            var field = (string)dr["Category"];
                            p.Category = (Category)Enum.Parse(typeof(Category), field);

                            list.Add(p);

                        }
                        db.Disconnect(db.getConnection);
                        return list;
                    }
                }
                db.Disconnect(db.getConnection);
                return null;
            }
        }

        public Product getById(long id)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "SELECT * FROM Product WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                db.Connect();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        Product p = new Product();
                        dr.Read();

                        p.Name = dr.GetString(dr.GetOrdinal("Name"));
                        p.Price = dr.GetDouble(dr.GetOrdinal("Price"));
                        p.Quantity = dr.GetInt32(dr.GetOrdinal("Quantity"));
                        var field = (string)dr["Category"];
                        p.Category = (Category)Enum.Parse(typeof(Category), field);

                        db.Disconnect(db.getConnection);
                        return p;
                    }
                }
                db.Disconnect(db.getConnection);
                return null;
            }
        }

        public void insert(Product o)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "INSERT INTO Product (Name, Price, Quantity, Category) " +
                                  "VALUES (@name, @price, @quantity, @category)";

                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@name", o.Name);
                cmd.Parameters.AddWithValue("@price", o.Price);
                cmd.Parameters.AddWithValue("@quantity", o.Quantity);
                cmd.Parameters.AddWithValue("@category", o.Category);

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

        public void updateAll(long id, Product o)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Product SET Name = @name, Price = @price, Quantity = @quantity, Category = @category WHERE Id = @id";

                cmd.Connection = db.getConnection;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", o.Name);
                cmd.Parameters.AddWithValue("@price", o.Price);
                cmd.Parameters.AddWithValue("@quantity", o.Quantity);
                cmd.Parameters.AddWithValue("@category", o.Category);
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
                cmd.CommandText = "UPDATE Product SET Name = @name WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
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

        public void updatePrice(long id, double price)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Product SET Price = @price WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@price", price);
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

        public void updateQuantity(long id, int quantity)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Product SET Quantity = @quantity WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@quantity", quantity);
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

        public void updateCategory(long id, Category category)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "UPDATE Product SET Category = @category WHERE Id = @id";
                cmd.Connection = db.getConnection;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@category", category);
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
