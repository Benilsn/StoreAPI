
using Store.controllers;
using Store.entities;
using Store.entities.Enum;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms.ProductForms
{
    public partial class ProductInsert : Form
    {
        public ProductInsert()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
            priceTb.Clear();
            quantityNUD.Value = 0;
            categoryNUD.Value = 1;
            nameTb.Focus();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Product p = new Product();

            try
            {
                if (nameTb.Text.Length < 2 || double.Parse(priceTb.Text) == 0 || quantityNUD.Value == 0 || categoryNUD.Value < 1 || categoryNUD.Value > 12)
                {
                    if (nameTb.Text.Length < 2)
                    {
                        MessageBox.Show("Invalid Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (double.Parse(priceTb.Text) == 0)
                    {
                        MessageBox.Show("Invalid Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (quantityNUD.Value == 0)
                    {
                        MessageBox.Show("Invalid Quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Category\n1 up to 12!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ProductController sc = new ProductController();
                    p.Name = nameTb.Text;
                    p.Price = double.Parse(priceTb.Text);
                    p.Quantity = (int)quantityNUD.Value;
                    p.Category = (Category)categoryNUD.Value;
                    sc.insert(p);
                    nameTb.Clear();
                    priceTb.Clear();
                    quantityNUD.Value = 0;
                    categoryNUD.Value = 1;
                    MessageBox.Show("Product added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
