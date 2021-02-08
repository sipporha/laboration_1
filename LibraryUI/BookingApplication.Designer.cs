
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooked)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Skapa bokning";
            // 
            // dataGridViewMember
            // 
            this.dataGridViewMember.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMember.Location = new System.Drawing.Point(50, 229);
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
            this.dataGridViewBook.Location = new System.Drawing.Point(50, 715);
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
            this.Medlemmar.Location = new System.Drawing.Point(50, 185);
            this.Medlemmar.Name = "Medlemmar";
            this.Medlemmar.Size = new System.Drawing.Size(125, 30);
            this.Medlemmar.TabIndex = 3;
            this.Medlemmar.Text = "Medlemmar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 670);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Böcker";
            // 
            // buttonAddMember
            // 
            this.buttonAddMember.Location = new System.Drawing.Point(50, 517);
            this.buttonAddMember.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddMember.Name = "buttonAddMember";
            this.buttonAddMember.Size = new System.Drawing.Size(163, 54);
            this.buttonAddMember.TabIndex = 5;
            this.buttonAddMember.Text = "Lägg till";
            this.buttonAddMember.UseVisualStyleBackColor = true;
            this.buttonAddMember.Click += new System.EventHandler(this.buttonAddMember_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(50, 1214);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(163, 54);
            this.buttonAddBook.TabIndex = 6;
            this.buttonAddBook.Text = "Lägg till bok";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // buttonAddBooking
            // 
            this.buttonAddBooking.Location = new System.Drawing.Point(1646, 634);
            this.buttonAddBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddBooking.Name = "buttonAddBooking";
            this.buttonAddBooking.Size = new System.Drawing.Size(163, 54);
            this.buttonAddBooking.TabIndex = 8;
            this.buttonAddBooking.Text = "OK";
            this.buttonAddBooking.UseVisualStyleBackColor = true;
            this.buttonAddBooking.Click += new System.EventHandler(this.buttonAddBooking_Click);
            // 
            // dataGridViewBooked
            // 
            this.dataGridViewBooked.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBooked.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooked.Location = new System.Drawing.Point(1141, 374);
            this.dataGridViewBooked.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBooked.Name = "dataGridViewBooked";
            this.dataGridViewBooked.RowHeadersWidth = 72;
            this.dataGridViewBooked.RowTemplate.Height = 37;
            this.dataGridViewBooked.Size = new System.Drawing.Size(668, 237);
            this.dataGridViewBooked.TabIndex = 9;
            // 
            // textBoxLoaner
            // 
            this.textBoxLoaner.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxLoaner.Location = new System.Drawing.Point(1141, 225);
            this.textBoxLoaner.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBoxLoaner.Multiline = true;
            this.textBoxLoaner.Name = "textBoxLoaner";
            this.textBoxLoaner.ReadOnly = true;
            this.textBoxLoaner.Size = new System.Drawing.Size(668, 74);
            this.textBoxLoaner.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1141, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Låntagare";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1439, 658);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "Skapa ny bokning?";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(1141, 881);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(646, 304);
            this.listBox1.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1141, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "Boklista";
            // 
            // BookingApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1925, 1396);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label5;
    }
}