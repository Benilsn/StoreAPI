using System;
using Store.controllers;
using Store.database;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace StoreApp.Forms.StaffForms
{
    public partial class GetAll : Form
    {
        public GetAll()
        {
            InitializeComponent();
            staffGetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void staffGetAll()
        {
            StaffController sc = new StaffController();
            DataBase db = new DataBase();
            try
            {
                string sqlcmd = "SELECT Id,Name,Age,Role,EntryDate,Department FROM Staff";

                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, db.getConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }
            finally
            {
                db.Disconnect(db.getConnection);
            }

        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            staffGetAll();
        }
    }
}
