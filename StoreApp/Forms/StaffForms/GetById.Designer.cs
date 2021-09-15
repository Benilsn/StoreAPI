
namespace StoreApp.Forms
{
    partial class GetById
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetById));
            this.closeBtn = new System.Windows.Forms.Button();
            this.staffFormMainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.staffInfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.memberName = new System.Windows.Forms.Label();
            this.memberID = new System.Windows.Forms.Label();
            this.memberDepartment = new System.Windows.Forms.Label();
            this.memberEntryDate = new System.Windows.Forms.Label();
            this.memberRole = new System.Windows.Forms.Label();
            this.memberAge = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.staffFormMainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.staffInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            resources.ApplyResources(this.closeBtn, "closeBtn");
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // staffFormMainPanel
            // 
            this.staffFormMainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(152)))), ((int)(((byte)(156)))));
            this.staffFormMainPanel.Controls.Add(this.panel1);
            this.staffFormMainPanel.Controls.Add(this.staffInfoPanel);
            this.staffFormMainPanel.Controls.Add(this.closeBtn);
            resources.ApplyResources(this.staffFormMainPanel, "staffFormMainPanel");
            this.staffFormMainPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.staffFormMainPanel.Name = "staffFormMainPanel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.idTB);
            this.panel1.Controls.Add(this.confirmBtn);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // idTB
            // 
            resources.ApplyResources(this.idTB, "idTB");
            this.idTB.Name = "idTB";
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            resources.ApplyResources(this.confirmBtn, "confirmBtn");
            this.confirmBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // staffInfoPanel
            // 
            this.staffInfoPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.staffInfoPanel.Controls.Add(this.label2);
            this.staffInfoPanel.Controls.Add(this.label9);
            this.staffInfoPanel.Controls.Add(this.memberName);
            this.staffInfoPanel.Controls.Add(this.memberID);
            this.staffInfoPanel.Controls.Add(this.memberDepartment);
            this.staffInfoPanel.Controls.Add(this.memberEntryDate);
            this.staffInfoPanel.Controls.Add(this.memberRole);
            this.staffInfoPanel.Controls.Add(this.memberAge);
            this.staffInfoPanel.Controls.Add(this.label4);
            this.staffInfoPanel.Controls.Add(this.label6);
            this.staffInfoPanel.Controls.Add(this.label7);
            this.staffInfoPanel.Controls.Add(this.label3);
            this.staffInfoPanel.Controls.Add(this.label5);
            resources.ApplyResources(this.staffInfoPanel, "staffInfoPanel");
            this.staffInfoPanel.Name = "staffInfoPanel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // memberName
            // 
            resources.ApplyResources(this.memberName, "memberName");
            this.memberName.Name = "memberName";
            // 
            // memberID
            // 
            resources.ApplyResources(this.memberID, "memberID");
            this.memberID.Name = "memberID";
            // 
            // memberDepartment
            // 
            resources.ApplyResources(this.memberDepartment, "memberDepartment");
            this.memberDepartment.Name = "memberDepartment";
            // 
            // memberEntryDate
            // 
            resources.ApplyResources(this.memberEntryDate, "memberEntryDate");
            this.memberEntryDate.Name = "memberEntryDate";
            // 
            // memberRole
            // 
            resources.ApplyResources(this.memberRole, "memberRole");
            this.memberRole.Name = "memberRole";
            // 
            // memberAge
            // 
            resources.ApplyResources(this.memberAge, "memberAge");
            this.memberAge.Name = "memberAge";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // GetById
            // 
            this.AcceptButton = this.closeBtn;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ControlBox = false;
            this.Controls.Add(this.staffFormMainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GetById";
            this.staffFormMainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.staffInfoPanel.ResumeLayout(false);
            this.staffInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel staffFormMainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel staffInfoPanel;
        private System.Windows.Forms.Label memberDepartment;
        private System.Windows.Forms.Label memberEntryDate;
        private System.Windows.Forms.Label memberRole;
        private System.Windows.Forms.Label memberAge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label memberName;
        private System.Windows.Forms.Label memberID;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
    }
}