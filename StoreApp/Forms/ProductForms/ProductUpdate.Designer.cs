
namespace StoreApp.Forms.ProductForms
{
    partial class ProductUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.getAllBtn = new System.Windows.Forms.Button();
            this.productUpdateDesktop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteIdTb = new System.Windows.Forms.TextBox();
            this.deleteSubmitBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updateLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.idTb = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.updateTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.productUpdateDesktop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.updateBtn);
            this.panel1.Controls.Add(this.getAllBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteBtn.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteBtn.Location = new System.Drawing.Point(34, 81);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(132, 42);
            this.deleteBtn.TabIndex = 34;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(255)))), ((int)(((byte)(211)))));
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateBtn.Image = ((System.Drawing.Image)(resources.GetObject("updateBtn.Image")));
            this.updateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateBtn.Location = new System.Drawing.Point(34, 18);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(132, 44);
            this.updateBtn.TabIndex = 33;
            this.updateBtn.Text = "Update";
            this.updateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // getAllBtn
            // 
            this.getAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(133)))), ((int)(((byte)(155)))));
            this.getAllBtn.FlatAppearance.BorderSize = 0;
            this.getAllBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.getAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.getAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.getAllBtn.Font = new System.Drawing.Font("Russo One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.getAllBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.getAllBtn.Image = ((System.Drawing.Image)(resources.GetObject("getAllBtn.Image")));
            this.getAllBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.getAllBtn.Location = new System.Drawing.Point(34, 373);
            this.getAllBtn.Name = "getAllBtn";
            this.getAllBtn.Size = new System.Drawing.Size(132, 59);
            this.getAllBtn.TabIndex = 32;
            this.getAllBtn.Text = "Get all products";
            this.getAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.getAllBtn.UseVisualStyleBackColor = false;
            this.getAllBtn.Click += new System.EventHandler(this.getAllBtn_Click);
            // 
            // productUpdateDesktop
            // 
            this.productUpdateDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(184)))), ((int)(((byte)(154)))));
            this.productUpdateDesktop.Controls.Add(this.panel3);
            this.productUpdateDesktop.Controls.Add(this.panel2);
            this.productUpdateDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productUpdateDesktop.Location = new System.Drawing.Point(200, 0);
            this.productUpdateDesktop.Name = "productUpdateDesktop";
            this.productUpdateDesktop.Size = new System.Drawing.Size(344, 450);
            this.productUpdateDesktop.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.deleteIdTb);
            this.panel3.Controls.Add(this.deleteSubmitBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 195);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 120);
            this.panel3.TabIndex = 0;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID: ";
            // 
            // deleteIdTb
            // 
            this.deleteIdTb.Location = new System.Drawing.Point(63, 46);
            this.deleteIdTb.Name = "deleteIdTb";
            this.deleteIdTb.Size = new System.Drawing.Size(100, 23);
            this.deleteIdTb.TabIndex = 4;
            // 
            // deleteSubmitBtn
            // 
            this.deleteSubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.deleteSubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSubmitBtn.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.deleteSubmitBtn.Location = new System.Drawing.Point(195, 48);
            this.deleteSubmitBtn.Name = "deleteSubmitBtn";
            this.deleteSubmitBtn.Size = new System.Drawing.Size(83, 21);
            this.deleteSubmitBtn.TabIndex = 3;
            this.deleteSubmitBtn.TabStop = false;
            this.deleteSubmitBtn.Text = "Submit";
            this.deleteSubmitBtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.updateLb);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.idTb);
            this.panel2.Controls.Add(this.submitBtn);
            this.panel2.Controls.Add(this.updateTB);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 195);
            this.panel2.TabIndex = 0;
            this.panel2.Visible = false;
            // 
            // updateLb
            // 
            this.updateLb.AutoSize = true;
            this.updateLb.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.updateLb.Location = new System.Drawing.Point(20, 121);
            this.updateLb.Name = "updateLb";
            this.updateLb.Size = new System.Drawing.Size(55, 16);
            this.updateLb.TabIndex = 45;
            this.updateLb.Text = "Update";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 19);
            this.label2.TabIndex = 44;
            this.label2.Text = "ID:";
            // 
            // idTb
            // 
            this.idTb.Location = new System.Drawing.Point(20, 92);
            this.idTb.Name = "idTb";
            this.idTb.Size = new System.Drawing.Size(100, 23);
            this.idTb.TabIndex = 43;
            // 
            // submitBtn
            // 
            this.submitBtn.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.submitBtn.Location = new System.Drawing.Point(241, 81);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(91, 42);
            this.submitBtn.TabIndex = 42;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // updateTB
            // 
            this.updateTB.Location = new System.Drawing.Point(20, 143);
            this.updateTB.Name = "updateTB";
            this.updateTB.Size = new System.Drawing.Size(172, 23);
            this.updateTB.TabIndex = 41;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Name",
            "Price",
            "Quantity",
            "Category"});
            this.comboBox1.Location = new System.Drawing.Point(20, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 24);
            this.comboBox1.TabIndex = 40;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 450);
            this.ControlBox = false;
            this.Controls.Add(this.productUpdateDesktop);
            this.Controls.Add(this.panel1);
            this.Name = "ProductUpdate";
            this.panel1.ResumeLayout(false);
            this.productUpdateDesktop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel productUpdateDesktop;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button getAllBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTb;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox updateTB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteIdTb;
        private System.Windows.Forms.Button deleteSubmitBtn;
        private System.Windows.Forms.Label updateLb;
    }
}