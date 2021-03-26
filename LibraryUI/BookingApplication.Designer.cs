
namespace LibraryUI
{
    partial class BookingApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewMember = new System.Windows.Forms.DataGridView();
            this.dataGridViewBook = new System.Windows.Forms.DataGridView();
            this.Medlemmar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddMember = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.buttonAddBooking = new System.Windows.Forms.Button();
            this.dataGridViewBooked = new System.Windows.Forms.DataGridView();
            this.textBoxLoaner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelLåntagareFail = new System.Windows.Forms.Label();
            this.labelFailBok = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooked)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skapa bokning";
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(38, 220);
            this.dataGridViewMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewMember.Name = "dataGridViewMember";
            this.dataGridViewMember.RowHeadersWidth = 72;
            this.dataGridViewMember.RowTemplate.Height = 37;
            this.dataGridViewMember.Size = new System.Drawing.Size(897, 280);
            this.dataGridViewMember.TabIndex = 1;
            // 
            // dataGridViewBook
            // 
            this.dataGridViewBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBook.Location = new System.Drawing.Point(38, 708);
            this.dataGridViewBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBook.Name = "dataGridViewBook";
            this.dataGridViewBook.RowHeadersWidth = 72;
            this.dataGridViewBook.RowTemplate.Height = 37;
            this.dataGridViewBook.Size = new System.Drawing.Size(897, 470);
            this.dataGridViewBook.TabIndex = 2;
            // 
            // Medlemmar
            // 
            this.Medlemmar.AutoSize = true;
            this.Medlemmar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Medlemmar.Location = new System.Drawing.Point(38, 164);
            this.Medlemmar.Name = "Medlemmar";
            this.Medlemmar.Size = new System.Drawing.Size(172, 38);
            this.Medlemmar.TabIndex = 3;
            this.Medlemmar.Text = "Medlemmar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Böcker";
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMember.Location = new System.Drawing.Point(38, 508);
            this.buttonAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(163, 54);
            this.buttonAddMember.TabIndex = 5;
            this.buttonAddMember.Text = "Lägg till";
            this.buttonAddMember.UseVisualStyleBackColor = false;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBook.Location = new System.Drawing.Point(38, 1206);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(163, 54);
            this.buttonAddBook.TabIndex = 6;
            this.buttonAddBook.Text = "Lägg till bok";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonAddBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddBooking.Location = new System.Drawing.Point(1507, 672);
            this.buttonAddBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(163, 54);
            this.buttonAddBooking.TabIndex = 8;
            this.buttonAddBooking.Text = "OK";
            this.buttonAddBooking.UseVisualStyleBackColor = false;
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            // 
            // dataGridViewBooked
            // 
            this.dataGridViewBooked.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBooked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooked.Location = new System.Drawing.Point(1001, 382);
            this.dataGridViewBooked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBooked.Name = "dataGridViewBooked";
            this.dataGridViewBooked.RowHeadersWidth = 72;
            this.dataGridViewBooked.RowTemplate.Height = 37;
            this.dataGridViewBooked.Size = new System.Drawing.Size(669, 236);
            this.dataGridViewBooked.TabIndex = 9;
            // 
            // textBoxLoaner
            // 
            this.textBoxLoaner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLoaner.Location = new System.Drawing.Point(999, 220);
            this.textBoxLoaner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxLoaner.Multiline = true;
            this.textBoxLoaner.Name = "textBoxLoaner";
            this.textBoxLoaner.ReadOnly = true;
            this.textBoxLoaner.Size = new System.Drawing.Size(667, 74);
            this.textBoxLoaner.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(999, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 38);
            this.label3.TabIndex = 11;
            this.label3.Text = "Låntagare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1261, 689);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 37);
            this.label4.TabIndex = 12;
            this.label4.Text = "Skapa ny bokning?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1001, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Boklista";
            // 
            // labelLåntagareFail
            // 
            this.labelLåntagareFail.AutoSize = true;
            this.labelLåntagareFail.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLåntagareFail.Location = new System.Drawing.Point(1423, 304);
            this.labelLåntagareFail.Name = "labelLåntagareFail";
            this.labelLåntagareFail.Size = new System.Drawing.Size(57, 30);
            this.labelLåntagareFail.TabIndex = 15;
            this.labelLåntagareFail.Text = "label";
            // 
            // labelFailBok
            // 
            this.labelFailBok.AutoSize = true;
            this.labelFailBok.ForeColor = System.Drawing.Color.DarkRed;
            this.labelFailBok.Location = new System.Drawing.Point(1423, 626);
            this.labelFailBok.Name = "labelFailBok";
            this.labelFailBok.Size = new System.Drawing.Size(57, 30);
            this.labelFailBok.TabIndex = 16;
            this.labelFailBok.Text = "label";
            // 
            // BookingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1714, 1400);
            this.Controls.Add(this.labelFailBok);
            this.Controls.Add(this.labelLåntagareFail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLoaner);
            this.Controls.Add(this.dataGridViewBooked);
            this.Controls.Add(this.buttonAddBooking);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonAddMember);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Medlemmar);
            this.Controls.Add(this.dataGridViewBook);
            this.Controls.Add(this.dataGridViewMember);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookingApplication";
            this.Text = "BokningsApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewMember;
        private System.Windows.Forms.DataGridView dataGridViewBook;
        private System.Windows.Forms.Label Medlemmar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddMember;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonAddBooking;
        private System.Windows.Forms.DataGridView dataGridViewBooked;
        private System.Windows.Forms.TextBox textBoxLoaner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelLåntagareFail;
        private System.Windows.Forms.Label labelFailBok;
    }
}