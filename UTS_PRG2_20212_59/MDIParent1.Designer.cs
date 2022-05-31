
namespace UTS_PRG2_20212_59
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inputKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewKaryawanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterGolonganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterKaryawanToolStripMenuItem,
            this.masterGolonganToolStripMenuItem,
            this.transaksiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterKaryawanToolStripMenuItem
            // 
            this.masterKaryawanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputKaryawanToolStripMenuItem,
            this.updateKaryawanToolStripMenuItem,
            this.viewKaryawanToolStripMenuItem});
            this.masterKaryawanToolStripMenuItem.Name = "masterKaryawanToolStripMenuItem";
            this.masterKaryawanToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.masterKaryawanToolStripMenuItem.Text = "Master Karyawan";
            // 
            // inputKaryawanToolStripMenuItem
            // 
            this.inputKaryawanToolStripMenuItem.Name = "inputKaryawanToolStripMenuItem";
            this.inputKaryawanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inputKaryawanToolStripMenuItem.Text = "Input Karyawan";
            this.inputKaryawanToolStripMenuItem.Click += new System.EventHandler(this.inputKaryawanToolStripMenuItem_Click);
            // 
            // updateKaryawanToolStripMenuItem
            // 
            this.updateKaryawanToolStripMenuItem.Name = "updateKaryawanToolStripMenuItem";
            this.updateKaryawanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateKaryawanToolStripMenuItem.Text = "Update Karyawan";
            this.updateKaryawanToolStripMenuItem.Click += new System.EventHandler(this.updateKaryawanToolStripMenuItem_Click);
            // 
            // viewKaryawanToolStripMenuItem
            // 
            this.viewKaryawanToolStripMenuItem.Name = "viewKaryawanToolStripMenuItem";
            this.viewKaryawanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewKaryawanToolStripMenuItem.Text = "View Karyawan";
            this.viewKaryawanToolStripMenuItem.Click += new System.EventHandler(this.viewKaryawanToolStripMenuItem_Click);
            // 
            // masterGolonganToolStripMenuItem
            // 
            this.masterGolonganToolStripMenuItem.Name = "masterGolonganToolStripMenuItem";
            this.masterGolonganToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.masterGolonganToolStripMenuItem.Text = "Master Golongan";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            this.transaksiToolStripMenuItem.Click += new System.EventHandler(this.transaksiToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.Text = "Main Form";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inputKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewKaryawanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterGolonganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
    }
}



