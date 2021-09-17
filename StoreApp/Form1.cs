using System;
using StoreApp.Forms;
using System.Windows.Forms;
using StoreApp.Forms.StaffForms;
using StoreApp.Forms.ProductForms;

namespace StoreApp
{
    public partial class Form1 : Form
    {

        private Form currentForm;
        
        public Form1()
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
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            desktopPanel.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
            
        }


        // GET STAFF BY ID 
        private void getClientByIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new StaffGetById());
        }

        // GET ALL STAFF MEMBERS
        private void getAllClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new StaffGetAll());
        }

        // INSERT NEW STAFF MEMBER
        private void staffNewMember_Click(object sender, EventArgs e)
        {
            openNew(new StaffInsert());
        }

        // UPDATE MEMBER
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new StaffUpdate());
        }

        // GET ALL PRODUCT
        private void getAllProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new ProductGetAll());
        }

        // GET BY ID PRODUCT
        private void getProductByIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new ProductGetById());
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new ProductInsert());
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new ProductUpdate());
        }
    }
}
