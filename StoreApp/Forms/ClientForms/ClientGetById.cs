using Store.controllers;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms.ClientForms
{
    public partial class ClientGetById : Form
    {
        public ClientGetById()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            ClientController cc = new ClientController();

            try
            {
                var client = cc.getById(long.Parse(idTB.Text));
                if (client == null)
                {
                    MessageBox.Show("ID Not Found!");
                }
                else
                {
                    clientInfoPanel.Visible = true;
                    clientID.Text = idTB.Text;
                    clientName.Text = client.Name;
                    clientAge.Text = client.Age.ToString();
                    clientMemberSince.Text = client.Date.ToString().Substring(0, 10);
                    clientPhone.Text = client.Phone;

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
