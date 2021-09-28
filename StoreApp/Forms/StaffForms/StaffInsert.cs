using Store.controllers;
using Store.entities;
using Store.entities.Enum;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace StoreApp.Forms.StaffForms
{
    public partial class StaffInsert : Form
    {

        StaffController sc = new StaffController();

        public StaffInsert()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Staff s = new Staff();

            try
            {
                if (nameTb.Text.Length < 3 || int.Parse(ageTb.Text) < 16 || roleTb.Text.Length < 3)
                {
                    if (nameTb.Text.Length < 3)
                    {
                        MessageBox.Show("Invalid Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (int.Parse(ageTb.Text) < 16)
                    {
                        MessageBox.Show("Invalid Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (roleTb.Text.Length < 3)
                    {
                        MessageBox.Show("Invalid Role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    s.Name = nameTb.Text;
                    s.Age = int.Parse(ageTb.Text);
                    s.Role = roleTb.Text;
                    if (entrydateTb.Value.Date > DateTime.Now)
                    {
                        MessageBox.Show("Please choose a valid date!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        s.Entry_Date = entrydateTb.Value.Date;
                    }
                    s.Department = (Department)departmentTb.Value;
                    sc.insert(s);

                    if (sc.getByName(s.Name) != 0)
                    {
                        MessageBox.Show("Successfully added!\nID:" + sc.getByName(s.Name), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nameTb.Clear();
                        ageTb.Clear();
                        roleTb.Clear();
                        departmentTb.Value = 0;
                    }
                    else
                    {
                        MessageBox.Show("Failed to add member!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Age!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlTypeException)
            {

            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
            ageTb.Clear();
            roleTb.Clear();
            departmentTb.Value = 0;
                       
        }
    }
}
