using Store.controllers;
using Store.entities;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StoreApp.Forms.ClientForms
{
    public partial class ClientInsert : Form
    {

        ClientController cc = new ClientController();
        public ClientInsert()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cleanBtn_Click(object sender, EventArgs e)
        {
            nameTB.Clear();
            ageTB.Clear();
            phoneTB.Clear();
            nameTB.Focus();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Client c = new Client();

            try
            {
                if (nameTB.Text.Length < 3 || int.Parse(ageTB.Text) < 12 || phoneTB.Text.Length < 8 || phoneTB.Text.Length > 11 || memberSinceTB.Value.Date > DateTime.Now)
                {
                    if (nameTB.Text.Length < 3)
                    {
                        MessageBox.Show("Invalid Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (int.Parse(ageTB.Text) < 12)
                    {
                        MessageBox.Show("Invalid Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (phoneTB.Text.Length < 8)
                    {
                        MessageBox.Show("Phone number its too short!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (phoneTB.Text.Length > 11)
                    {
                        MessageBox.Show("Phone number its too big!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (memberSinceTB.Value.Date > DateTime.Now)
                    {
                        MessageBox.Show("You cannot choose a future date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    c.Name = nameTB.Text;
                    c.Age = int.Parse(ageTB.Text);
                    c.Date = memberSinceTB.Value.Date;
                    c.Phone = phoneTB.Text;
                    cc.insert(c);
                    MessageBox.Show("Client Created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nameTB.Clear();
                    ageTB.Clear();
                    phoneTB.Clear();
                    nameTB.Focus();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Untreated!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
