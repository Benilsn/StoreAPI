using System;
using StoreApp.Forms;
using System.Windows.Forms;
using StoreApp.Forms.StaffForms;

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
            openNew(new GetById());
        }

        // GET ALL STAFF MEMBERS
        private void getAllClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new GetAll());
        }

        // INSERT NEW STAFF MEMBER
        private void staffNewMember_Click(object sender, EventArgs e)
        {
            openNew(new Insert());
        }

        // UPDATE MEMBER
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openNew(new Update());
        }
    }
}
