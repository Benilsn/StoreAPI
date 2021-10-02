using Store.controllers;
using Store.entities.Enum;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms.StaffForms
{
    public partial class StaffUpdate : Form
    {
        private Form currentForm;
        StaffRepository sc = new StaffRepository();

        public StaffUpdate()
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // GET ALL BUTTON
        private void button1_Click(object sender, EventArgs e)
        {
            openNew(new StaffGetAll());

        }

        //UPDATE BUTTON
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (updatePanel.Visible == true)
            {
                updatePanel.Visible = false;
            }
            else
            {
                delPn.Visible = false;
                updatePanel.Visible = true;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            try
            {
                var cb = comboBox1.SelectedItem;
                var id = long.Parse(idTb.Text);

                if (sc.getById(id) == null)
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
                                if (updateTB.Text.Length < 3)
                                {
                                    MessageBox.Show("Name is to short!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    sc.updateName(id, updateTB.Text);
                                    idTb.Clear();
                                    updateTB.Clear();
                                    MessageBox.Show("Name updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;
                            case "Age":
                                var age = int.Parse(updateTB.Text);
                                if (age.GetType().Equals(typeof(string)))
                                {
                                    MessageBox.Show("Please choose a valid age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    sc.updateAge(id, int.Parse(updateTB.Text));
                                    idTb.Clear();
                                    updateTB.Clear();
                                    MessageBox.Show("Age updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                break;

                            case "Role":
                                sc.updateRole(id, updateTB.Text);
                                idTb.Clear();
                                updateTB.Clear();
                                MessageBox.Show("Role updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case "EntryDate":

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
                                        sc.updateEntryDate(id, DateTime.Parse(updateTB.Text));
                                        idTb.Clear();
                                        updateTB.Clear();
                                        MessageBox.Show("EntryDate updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                                break;
                            case "Department":
                                Department dp;
                                bool boolDp = Enum.TryParse(updateTB.Text, out dp);
                                if (boolDp == false)
                                {
                                    MessageBox.Show("Invalid department type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (int.Parse(updateTB.Text) > 11)
                                {
                                    MessageBox.Show("Invalid department!\nChoose 1 to 11", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else
                                {
                                    sc.updateDepartment(id, (Department)Enum.Parse(typeof(Department), updateTB.Text));
                                    idTb.Clear();
                                    updateTB.Clear();
                                    MessageBox.Show("Department updated!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateLb.Text = "New " + comboBox1.SelectedItem.ToString() + ": ";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (delPn.Visible == true)
            {
                delPn.Visible = false;
            }
            else
            {
                updatePanel.Visible = false;
                delPn.Visible = true;
            }

        }

        private void deleteSubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var id = sc.getById(long.Parse(deleteIdTb.Text));

                if (id == null)
                {
                    MessageBox.Show("ID Not Found", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    sc.deleteById(id.Id);
                    MessageBox.Show("Deleted successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deleteIdTb.Clear();
                    deleteIdTb.Focus();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid ID!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
