
namespace StoreApp.Forms.ClientForms
{
    partial class ClientGetById
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientGetById));
            this.clientFormDesktop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.clientInfoPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.Label();
            this.clientID = new System.Windows.Forms.Label();
            this.clientPhone = new System.Windows.Forms.Label();
            this.clientMemberSince = new System.Windows.Forms.Label();
            this.clientAge = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.clientFormDesktop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.clientInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // clientFormDesktop
            // 
            this.clientFormDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(106)))), ((int)(((byte)(129)))));
            this.clientFormDesktop.Controls.Add(this.clientInfoPanel);
            this.clientFormDesktop.Controls.Add(this.closeBtn);
            this.clientFormDesktop.Controls.Add(this.panel2);
            this.clientFormDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientFormDesktop.Location = new System.Drawing.Point(0, 0);
            this.clientFormDesktop.Name = "clientFormDesktop";
            this.clientFormDesktop.Size = new System.Drawing.Size(544, 450);
            this.clientFormDesktop.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(53)))), ((int)(((byte)(85)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.idTB);
            this.panel2.Controls.Add(this.confirmBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 450);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(28, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 150);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(72, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client ID :";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(55, 244);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(115, 23);
            this.idTB.TabIndex = 6;
            // 
            // confirmBtn
            // 
            this.confirmBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmBtn.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.confirmBtn.ForeColor = System.Drawing.Color.Black;
            this.confirmBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.confirmBtn.Location = new System.Drawing.Point(95, 273);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 8;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = false;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
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
            this.closeBtn.TabIndex = 1;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // clientInfoPanel
            // 
            this.clientInfoPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clientInfoPanel.Controls.Add(this.label2);
            this.clientInfoPanel.Controls.Add(this.label9);
            this.clientInfoPanel.Controls.Add(this.clientName);
            this.clientInfoPanel.Controls.Add(this.clientID);
            this.clientInfoPanel.Controls.Add(this.clientPhone);
            this.clientInfoPanel.Controls.Add(this.clientMemberSince);
            this.clientInfoPanel.Controls.Add(this.clientAge);
            this.clientInfoPanel.Controls.Add(this.label6);
            this.clientInfoPanel.Controls.Add(this.label7);
            this.clientInfoPanel.Controls.Add(this.label3);
            this.clientInfoPanel.Controls.Add(this.label5);
            this.clientInfoPanel.Location = new System.Drawing.Point(244, 44);
            this.clientInfoPanel.Name = "clientInfoPanel";
            this.clientInfoPanel.Size = new System.Drawing.Size(279, 373);
            this.clientInfoPanel.TabIndex = 11;
            this.clientInfoPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(83, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Client Info :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(106, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "ID :";
            // 
            // clientName
            // 
            this.clientName.AutoSize = true;
            this.clientName.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientName.Location = new System.Drawing.Point(166, 116);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(34, 16);
            this.clientName.TabIndex = 17;
            this.clientName.Text = ".........";
            // 
            // clientID
            // 
            this.clientID.AutoSize = true;
            this.clientID.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientID.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientID.Location = new System.Drawing.Point(166, 74);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(34, 16);
            this.clientID.TabIndex = 16;
            this.clientID.Text = ".........";
            // 
            // clientPhone
            // 
            this.clientPhone.AutoSize = true;
            this.clientPhone.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientPhone.Location = new System.Drawing.Point(166, 273);
            this.clientPhone.Name = "clientPhone";
            this.clientPhone.Size = new System.Drawing.Size(34, 16);
            this.clientPhone.TabIndex = 14;
            this.clientPhone.Text = ".........";
            // 
            // clientMemberSince
            // 
            this.clientMemberSince.AutoSize = true;
            this.clientMemberSince.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientMemberSince.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientMemberSince.Location = new System.Drawing.Point(166, 223);
            this.clientMemberSince.Name = "clientMemberSince";
            this.clientMemberSince.Size = new System.Drawing.Size(34, 16);
            this.clientMemberSince.TabIndex = 13;
            this.clientMemberSince.Text = ".........";
            // 
            // clientAge
            // 
            this.clientAge.AutoSize = true;
            this.clientAge.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientAge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clientAge.Location = new System.Drawing.Point(166, 169);
            this.clientAge.Name = "clientAge";
            this.clientAge.Size = new System.Drawing.Size(34, 16);
            this.clientAge.TabIndex = 10;
            this.clientAge.Text = ".........";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(95, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Age :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(30, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "MemberSince :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(83, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(79, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone :";
            // 
            // ClientGetById
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.ControlBox = false;
            this.Controls.Add(this.clientFormDesktop);
            this.Name = "ClientGetById";
            this.ShowInTaskbar = false;
            this.clientFormDesktop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.clientInfoPanel.ResumeLayout(false);
            this.clientInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel clientFormDesktop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.Button confirmBtn;
        internal System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel clientInfoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label clientName;
        private System.Windows.Forms.Label clientID;
        private System.Windows.Forms.Label clientPhone;
        private System.Windows.Forms.Label clientMemberSince;
        private System.Windows.Forms.Label clientAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}