using Store.controllers;
using Store.database;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreApp.Forms.ProductForms
{
    public partial class ProductGetAll : Form
    {
        public ProductGetAll()
        {
            InitializeComponent();
            productGetAll();

        }

        private void productGetAll()
        {
            ProductController sc = new ProductController();
            DataBase db = new DataBase();
            try
            {
                string sqlcmd = "SELECT Id,Name,Price,Quantity,Category FROM Product";

                SqlDataAdapter sda = new SqlDataAdapter(sqlcmd, db.getConnection);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgvProduct.DataSource = dt;
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

        private void closeBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
