using Store.controllers;
using Store.entities;
using System;
using System.Windows.Forms;

namespace StoreApp.Forms
{
    public partial class GetById : Form
    {
        public GetById()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // GET BY ID STAFF
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            StaffController sc = new StaffController();

            try
            {
                var member = sc.getById(long.Parse(idTB.Text));
                if (member == null)
                {
                    MessageBox.Show("ID Not Found!");
                }
                else
                {
                    staffInfoPanel.Visible = true;
                    memberID.Text = idTB.Text;
                    memberName.Text = member.Name;
                    memberAge.Text = member.Age.ToString();
                    memberRole.Text = member.Role;
                    memberEntryDate.Text = member.Entry_Date.ToString().Substring(0, 10);
                    memberDepartment.Text = member.Department.ToString();
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
