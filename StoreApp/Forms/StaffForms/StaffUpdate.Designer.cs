
namespace StoreApp.Forms.StaffForms
{
    partial class StaffUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffUpdate));
            this.closeBtn = new System.Windows.Forms.Button();
            this.getAllBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.updateDesktop = new System.Windows.Forms.Panel();
            this.delPn = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteIdTb = new System.Windows.Forms.TextBox();
            this.deleteSubmitBtn = new System.Windows.Forms.Button();
            this.updatePanel = new System.Windows.Forms.Panel();
            this.updateLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updateTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.updateDesktop.SuspendLayout();
            this.delPn.SuspendLayout();
            this.updatePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeBtn.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.Color.Red;
            this.closeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBtn.Location = new System.Drawing.Point(522, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(19, 21);
            this.closeBtn.TabIndex = 27;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // getAllBtn
            // 
            this.getAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.getAllBtn.FlatAppearance.BorderSize = 0;
            this.getAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.getAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.getAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getAllBtn.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getAllBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("getAllBtn.Image")));
            this.getAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getAllBtn.Location = new System.Drawing.Point(26, 367);
            this.getAllBtn.Name = "getAllBtn";
            this.getAllBtn.Size = new System.Drawing.Size(132, 59);
            this.getAllBtn.TabIndex = 28;
            this.getAllBtn.Text = "Get all members";
            this.getAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.getAllBtn.UseVisualStyleBackColor = false;
            this.getAllBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(51)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.getAllBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 450);
            this.panel1.TabIndex = 29;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(26, 75);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 42);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(26, 12);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(132, 44);
            this.updateBtn.TabIndex = 30;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // updateDesktop
            // 
            this.updateDesktop.BackColor = System.Drawing.Color.Silver;
            this.updateDesktop.Controls.Add(this.delPn);
            this.updateDesktop.Controls.Add(this.updatePanel);
            this.updateDesktop.Controls.Add(this.panel1);
            this.updateDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateDesktop.Location = new System.Drawing.Point(0, 0);
            this.updateDesktop.Name = "updateDesktop";
            this.updateDesktop.Size = new System.Drawing.Size(544, 450);
            this.updateDesktop.TabIndex = 30;
            // 
            // delPn
            // 
            this.delPn.BackColor = System.Drawing.Color.Gray;
            this.delPn.Controls.Add(this.label3);
            this.delPn.Controls.Add(this.deleteIdTb);
            this.delPn.Controls.Add(this.deleteSubmitBtn);
            this.delPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.delPn.Location = new System.Drawing.Point(175, 207);
            this.delPn.Name = "delPn";
            this.delPn.Size = new System.Drawing.Size(369, 104);
            this.delPn.TabIndex = 34;
            this.delPn.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID: ";
            // 
            // deleteIdTb
            // 
            this.deleteIdTb.Location = new System.Drawing.Point(68, 36);
            this.deleteIdTb.Name = "deleteIdTb";
            this.deleteIdTb.Size = new System.Drawing.Size(100, 23);
            this.deleteIdTb.TabIndex = 1;
            // 
            // deleteSubmitBtn
            // 
            this.deleteSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSubmitBtn.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSubmitBtn.Location = new System.Drawing.Point(200, 38);
            this.deleteSubmitBtn.Name = "deleteSubmitBtn";
            this.deleteSubmitBtn.Size = new System.Drawing.Size(83, 21);
            this.deleteSubmitBtn.TabIndex = 0;
            this.deleteSubmitBtn.TabStop = false;
            this.deleteSubmitBtn.Text = "Submit";
            this.deleteSubmitBtn.UseVisualStyleBackColor = false;
            this.deleteSubmitBtn.Click += new System.EventHandler(this.deleteSubmitBtn_Click);
            // 
            // updatePanel
            // 
            this.updatePanel.BackColor = System.Drawing.Color.Gray;
            this.updatePanel.Controls.Add(this.updateLb);
            this.updatePanel.Controls.Add(this.label2);
            this.updatePanel.Controls.Add(this.idTb);
            this.updatePanel.Controls.Add(this.submitBtn);
            this.updatePanel.Controls.Add(this.label1);
            this.updatePanel.Controls.Add(this.updateTB);
            this.updatePanel.Controls.Add(this.comboBox1);
            this.updatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.updatePanel.Location = new System.Drawing.Point(175, 0);
            this.updatePanel.Name = "updatePanel";
            this.updatePanel.Size = new System.Drawing.Size(369, 207);
            this.updatePanel.TabIndex = 33;
            this.updatePanel.Visible = false;
            // 
            // updateLb
            // 
            this.updateLb.AutoSize = true;
            this.updateLb.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateLb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateLb.Location = new System.Drawing.Point(25, 126);
            this.updateLb.Name = "updateLb";
            this.updateLb.Size = new System.Drawing.Size(62, 16);
            this.updateLb.TabIndex = 39;
            this.updateLb.Text = "Update: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "ID:";
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(25, 100);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(100, 23);
            this.idTb.TabIndex = 36;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(238, 113);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(91, 42);
            this.submitBtn.TabIndex = 35;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Update: ";
            // 
            // updateTB
            // 
            this.updateTB.Location = new System.Drawing.Point(25, 145);
            this.updateTB.Name = "updateTB";
            this.updateTB.Size = new System.Drawing.Size(172, 23);
            this.updateTB.TabIndex = 33;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Age",
            "Role",
            "EntryDate",
            "Department"});
            this.comboBox1.Location = new System.Drawing.Point(25, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // StaffUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.ControlBox = false;
            this.Controls.Add(this.updateDesktop);
            this.Controls.Add(this.closeBtn);
            this.Name = "StaffUpdate";
            this.RightToLeftLayout = true;
            this.panel1.ResumeLayout(false);
            this.updateDesktop.ResumeLayout(false);
            this.delPn.ResumeLayout(false);
            this.delPn.PerformLayout();
            this.updatePanel.ResumeLayout(false);
            this.updatePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button getAllBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Panel updateDesktop;
        private System.Windows.Forms.Panel updatePanel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox updateTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Label updateLb;
        private System.Windows.Forms.Panel delPn;
        private System.Windows.Forms.TextBox deleteIdTb;
        private System.Windows.Forms.Button deleteSubmitBtn;
        private System.Windows.Forms.Label label3;
    }
}