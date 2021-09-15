
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
            this.clientTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.staffViewTSMI.Size = new System.Drawing.Size(180, 22);
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
            this.staffInsertTSMI.Size = new System.Drawing.Size(180, 22);
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
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Update/Delete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // productTSMI
            // 
            this.productTSMI.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productTSMI.Name = "productTSMI";
            this.productTSMI.Size = new System.Drawing.Size(71, 20);
            this.productTSMI.Text = "Product";
            // 
            // clientTSMI
            // 
            this.clientTSMI.Font = new System.Drawing.Font("Russo One", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clientTSMI.Name = "clientTSMI";
            this.clientTSMI.Size = new System.Drawing.Size(57, 20);
            this.clientTSMI.Text = "Client";
            // 
            // desktopPanel
            // 
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 24);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(544, 467);
            this.desktopPanel.TabIndex = 2;
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
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store API";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

