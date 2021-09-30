using Store.controllers;
using Store.entities.Enum;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms.ProductForms
{
    public partial class ProductUpdate : Form
    {

        private Form currentForm;
        ProductController pc = new ProductController();
        public ProductUpdate()
        {
            InitializeComponent();
        }

        private void openNew(Form newForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            currentForm = newForm;
            newForm.ControlBox = true;
            newForm.Show();
        }

        private void getAllBtn_Click(object sender, EventArgs e)
        {
            openNew(new ProductGetAll());
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
                panel3.Visible = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
            }
            else
            {
                panel3.Visible = true;
                panel2.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLb.Text = "New " + comboBox1.SelectedItem.ToString() + ": ";
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var cb = comboBox1.SelectedItem;
                var id = long.Parse(idTb.Text);

                if (pc.getById(id) == null)
                {
                    MessageBox.Show("ID Not Found!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (cb == null)
                    {
                        MessageBox.Show("Select something to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        switch (cb)
                        {
                            case "Name":
                                if (updateTB.Text.Length < 2)
                                {
                                    MessageBox.Show("Name is to short!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    pc.updateName(id, updateTB.Text);
                                    idTb.Clear();
                                    updateTB.Clear();
                                    MessageBox.Show("Name updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            case "Price":
                                try
                                {
                                    if (double.Parse(updateTB.Text) <= 0)
                                    {
                                        MessageBox.Show("Price can't be null/negative!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        pc.updatePrice(id, double.Parse(updateTB.Text));
                                        idTb.Clear();
                                        updateTB.Clear();
                                        MessageBox.Show("Price updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (FormatException)
                                {
                                    MessageBox.Show("Invalid Price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;

                            case "Quantity":
                                try
                                {
                                    if (int.Parse(updateTB.Text) < 0 || int.Parse(updateTB.Text) > 999)
                                    {
                                        MessageBox.Show("Invalid Quantity\n1 up to 999!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        pc.updatePrice(id, int.Parse(updateTB.Text));
                                        idTb.Clear();
                                        updateTB.Clear();
                                        MessageBox.Show("Quantity updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (FormatException)
                                {
                                    MessageBox.Show("Invalid Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                break;
                            case "Category":

                                Category c;
                                bool boolC = Enum.TryParse(updateTB.Text, out c);
                                if (boolC == false)
                                {
                                    MessageBox.Show("Invalid category type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (int.Parse(updateTB.Text) > 11)
                                {
                                    MessageBox.Show("Invalid category!\n1 up to 12", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    pc.updateCategory(id, (Category)Enum.Parse(typeof(Category), updateTB.Text));
                                    idTb.Clear();
                                    updateTB.Clear();
                                    MessageBox.Show("Category updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteSubmitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var id = long.Parse(deleteIdTb.Text);
                if (pc.getById(id) == null)
                {
                    MessageBox.Show("ID Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pc.deleteById(id);
                    MessageBox.Show("Product Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deleteIdTb.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
