using Store.repository;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms.ProductForms
{
    public partial class ProductGetById : Form
    {
        public ProductGetById()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            ProductRepository pc = new ProductRepository();

            try
            {
                var product = pc.getById(long.Parse(idTB.Text));
                if (product == null)
                {
                    MessageBox.Show("ID Not Found!");
                }
                else
                {
                    staffInfoPanel.Visible = true;
                    productID.Text = idTB.Text;
                    productName.Text = product.Name;
                    productPrice.Text = product.Price.ToString();
                    productQuantity.Text = product.Quantity.ToString();
                    productCategory.Text = product.Category.ToString();
                    idTB.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID!");
            }
        }


    }
}
