using Store.repository;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms.ClientForms
{
    public partial class ClientUpdate : Form
    {
        Form currentForm;
        ClientRepository cc = new ClientRepository();
        public ClientUpdate()
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
            openNew(new ClientGetAll());
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (updatePN.Visible == true)
            {
                updatePN.Visible = false;
            }
            else
            {
                updatePN.Visible = true;
                deletePN.Visible = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (deletePN.Visible == true)
            {
                deletePN.Visible = false;
            }
            else
            {
                deletePN.Visible = true;
                updatePN.Visible = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLb.Text = "New " + comboBox1.SelectedItem.ToString() + ": ";
        }

        private void deleteSubmitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var id = long.Parse(deleteIdTb.Text);

                if (cc.getById(id) == null)
                {
                    MessageBox.Show("ID Not Found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cc.deleteById(id);
                    deleteIdTb.Clear();
                    MessageBox.Show("Client deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var cb = comboBox1.SelectedItem;
                var id = long.Parse(idTB.Text);

                if (cc.getById(id) == null)
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
                                    cc.updateName(id, updateTB.Text);
                                    idTB.Clear();
                                    updateTB.Clear();
                                    MessageBox.Show("Name updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            case "Age":
                                try
                                {
                                    if (int.Parse(updateTB.Text) < 12 || int.Parse(updateTB.Text) > 99)
                                    {
                                        MessageBox.Show("Invalid Age", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        cc.updateAge(id, int.Parse(updateTB.Text));
                                        idTB.Clear();
                                        updateTB.Clear();
                                        MessageBox.Show("Age updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                catch (FormatException)
                                {
                                    MessageBox.Show("Invalid Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                break;
                            case "MemberSince":

                                DateTime date;
                                var date2 = DateTime.TryParse(updateTB.Text, out date);

                                if (date2 == false)
                                {
                                    MessageBox.Show("Invalid date format\ndd/mm/yyyy!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    if (date > DateTime.Now)
                                    {
                                        MessageBox.Show("Invalid date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    else
                                    {
                                        cc.updateDate(id, DateTime.Parse(updateTB.Text));
                                        idTB.Clear();
                                        updateTB.Clear();
                                        MessageBox.Show("Date updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                break;

                            case "Phone":
                                if (updateTB.Text.Length < 8 || updateTB.Text.Length > 11)
                                {
                                    MessageBox.Show("Invalid Phone number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                                else
                                {
                                    cc.updatePhone(id, updateTB.Text);
                                    break;
                                }
                        }
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID!", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
