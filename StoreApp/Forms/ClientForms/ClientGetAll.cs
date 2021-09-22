using System;
using System.Data;
using Store.controllers;
using Store.database;

using System.Windows.Forms;
using System.Data.SqlClient;

namespace StoreApp.Forms.ClientForms
{
    public partial class ClientGetAll : Form
    {
        public ClientGetAll()
        {
            InitializeComponent();
            clientGetAll();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clientGetAll()
        {
            ClientController cc = new ClientController();
            DataBase db = new DataBase();
            try
            {
                string sqlcmd = "SELECT Id,Name,Age,MemberSince,Phone FROM Client";

                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, db.getConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvClient.DataSource = dt;
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
    }
}
