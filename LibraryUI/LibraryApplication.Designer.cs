
namespace LibraryUI
{
    partial class LibraryApplication
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuBooking,
            this.toolStripMenuReturn});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(2230, 45);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuBooking
            // 
            this.toolStripMenuBooking.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuBooking.Name = "toolStripMenuBooking";
            this.toolStripMenuBooking.Size = new System.Drawing.Size(132, 41);
            this.toolStripMenuBooking.Text = "Bokning";
            this.toolStripMenuBooking.Click += new System.EventHandler(this.toolStripMenuBooking_Click);
            // 
            // toolStripMenuReturn
            // 
            this.toolStripMenuReturn.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripMenuReturn.Name = "toolStripMenuReturn";
            this.toolStripMenuReturn.Size = new System.Drawing.Size(196, 41);
            this.toolStripMenuReturn.Text = "Återlämnning";
            this.toolStripMenuReturn.Click += new System.EventHandler(this.toolStripMenuReturn_Click);
            // 
            // LibraryApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2230, 1547);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LibraryApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryApplication";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryApplication_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuBooking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuReturn;
    }
}