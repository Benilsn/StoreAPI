
namespace StoreApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.staffTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.staffViewTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.getClientByIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staffInsertTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.staffNewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getProductByIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getClientByIDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllClientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.desktopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Black;
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(544, 493);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffTSMI,
            this.productTSMI,
            this.clientTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(544, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // staffTSMI
            // 
            this.staffTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffViewTSMI,
            this.staffInsertTSMI,
            this.updateToolStripMenuItem});
            this.staffTSMI.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.staffTSMI.Name = "staffTSMI";
            this.staffTSMI.Size = new System.Drawing.Size(54, 20);
            this.staffTSMI.Text = "Staff";
            // 
            // staffViewTSMI
            // 
            this.staffViewTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getClientByIDToolStripMenuItem,
            this.getAllClientsToolStripMenuItem});
            this.staffViewTSMI.Name = "staffViewTSMI";
            this.staffViewTSMI.Size = new System.Drawing.Size(171, 22);
            this.staffViewTSMI.Text = "View";
            // 
            // getClientByIDToolStripMenuItem
            // 
            this.getClientByIDToolStripMenuItem.Name = "getClientByIDToolStripMenuItem";
            this.getClientByIDToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.getClientByIDToolStripMenuItem.Text = "Get Member by ID";
            this.getClientByIDToolStripMenuItem.Click += new System.EventHandler(this.getClientByIDToolStripMenuItem_Click);
            // 
            // getAllClientsToolStripMenuItem
            // 
            this.getAllClientsToolStripMenuItem.Name = "getAllClientsToolStripMenuItem";
            this.getAllClientsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.getAllClientsToolStripMenuItem.Text = "Get All Members";
            this.getAllClientsToolStripMenuItem.Click += new System.EventHandler(this.getAllClientsToolStripMenuItem_Click);
            // 
            // staffInsertTSMI
            // 
            this.staffInsertTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staffNewMember});
            this.staffInsertTSMI.Name = "staffInsertTSMI";
            this.staffInsertTSMI.Size = new System.Drawing.Size(171, 22);
            this.staffInsertTSMI.Text = "Insert";
            // 
            // staffNewMember
            // 
            this.staffNewMember.Name = "staffNewMember";
            this.staffNewMember.Size = new System.Drawing.Size(160, 22);
            this.staffNewMember.Text = "New Member";
            this.staffNewMember.Click += new System.EventHandler(this.staffNewMember_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateToolStripMenuItem.Text = "Update/Delete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // productTSMI
            // 
            this.productTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.updateDeleteToolStripMenuItem});
            this.productTSMI.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTSMI.Name = "productTSMI";
            this.productTSMI.Size = new System.Drawing.Size(71, 20);
            this.productTSMI.Text = "Product";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getProductByIdToolStripMenuItem,
            this.getAllProductsToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // getProductByIdToolStripMenuItem
            // 
            this.getProductByIdToolStripMenuItem.Name = "getProductByIdToolStripMenuItem";
            this.getProductByIdToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.getProductByIdToolStripMenuItem.Text = "Get Product by ID";
            this.getProductByIdToolStripMenuItem.Click += new System.EventHandler(this.getProductByIdToolStripMenuItem_Click);
            // 
            // getAllProductsToolStripMenuItem
            // 
            this.getAllProductsToolStripMenuItem.Name = "getAllProductsToolStripMenuItem";
            this.getAllProductsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.getAllProductsToolStripMenuItem.Text = "Get all Products";
            this.getAllProductsToolStripMenuItem.Click += new System.EventHandler(this.getAllProductsToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            // 
            // newProductToolStripMenuItem
            // 
            this.newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            this.newProductToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.newProductToolStripMenuItem.Text = "New Product";
            this.newProductToolStripMenuItem.Click += new System.EventHandler(this.newProductToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.updateDeleteToolStripMenuItem.Text = "Update/Delete";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click);
            // 
            // clientTSMI
            // 
            this.clientTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.insertToolStripMenuItem1,
            this.updateDeleteToolStripMenuItem1});
            this.clientTSMI.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientTSMI.Name = "clientTSMI";
            this.clientTSMI.Size = new System.Drawing.Size(57, 20);
            this.clientTSMI.Text = "Client";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.getClientByIDToolStripMenuItem1,
            this.getAllClientsToolStripMenuItem1});
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viewToolStripMenuItem1.Text = "View";
            // 
            // getClientByIDToolStripMenuItem1
            // 
            this.getClientByIDToolStripMenuItem1.Name = "getClientByIDToolStripMenuItem1";
            this.getClientByIDToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.getClientByIDToolStripMenuItem1.Text = "Get Client by ID";
            this.getClientByIDToolStripMenuItem1.Click += new System.EventHandler(this.getClientByIDToolStripMenuItem1_Click);
            // 
            // getAllClientsToolStripMenuItem1
            // 
            this.getAllClientsToolStripMenuItem1.Name = "getAllClientsToolStripMenuItem1";
            this.getAllClientsToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.getAllClientsToolStripMenuItem1.Text = "Get all Clients";
            this.getAllClientsToolStripMenuItem1.Click += new System.EventHandler(this.getAllClientsToolStripMenuItem1_Click);
            // 
            // insertToolStripMenuItem1
            // 
            this.insertToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductToolStripMenuItem1});
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            this.insertToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.insertToolStripMenuItem1.Text = "Insert";
            // 
            // newProductToolStripMenuItem1
            // 
            this.newProductToolStripMenuItem1.Name = "newProductToolStripMenuItem1";
            this.newProductToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.newProductToolStripMenuItem1.Text = "New Client";
            this.newProductToolStripMenuItem1.Click += new System.EventHandler(this.newProductToolStripMenuItem1_Click);
            // 
            // updateDeleteToolStripMenuItem1
            // 
            this.updateDeleteToolStripMenuItem1.Name = "updateDeleteToolStripMenuItem1";
            this.updateDeleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.updateDeleteToolStripMenuItem1.Text = "Update/Delete";
            this.updateDeleteToolStripMenuItem1.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem1_Click);
            // 
            // desktopPanel
            // 
            this.desktopPanel.BackColor = System.Drawing.Color.White;
            this.desktopPanel.Controls.Add(this.label2);
            this.desktopPanel.Controls.Add(this.label1);
            this.desktopPanel.Controls.Add(pictureBox1);
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.desktopPanel.Location = new System.Drawing.Point(0, 24);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(544, 467);
            this.desktopPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Russo One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(342, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "API";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Russo One", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(259, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Store Managment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(544, 491);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(560, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 530);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store API";
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.desktopPanel.ResumeLayout(false);
            this.desktopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productTSMI;
        private System.Windows.Forms.ToolStripMenuItem clientTSMI;
        private System.Windows.Forms.Panel desktopPanel;
        private System.Windows.Forms.ToolStripMenuItem staffTSMI;
        private System.Windows.Forms.ToolStripMenuItem staffViewTSMI;
        private System.Windows.Forms.ToolStripMenuItem getClientByIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staffInsertTSMI;
        private System.Windows.Forms.ToolStripMenuItem staffNewMember;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getProductByIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getAllProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getClientByIDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem getAllClientsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

