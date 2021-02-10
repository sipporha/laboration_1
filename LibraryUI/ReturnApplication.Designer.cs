
namespace LibraryUI
{
    partial class ReturnApplication
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
            this.dataGridViewBooking = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCancelBooking = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewInvoices = new System.Windows.Forms.DataGridView();
            this.buttonPayInvoice = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Återlämna böcker";
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(22, 112);
            this.dataGridViewBooking.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 72;
            this.dataGridViewBooking.RowTemplate.Height = 37;
            this.dataGridViewBooking.Size = new System.Drawing.Size(761, 172);
            this.dataGridViewBooking.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktuella bokningar";
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelBooking.Location = new System.Drawing.Point(673, 299);
            this.buttonCancelBooking.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(110, 30);
            this.buttonCancelBooking.TabIndex = 9;
            this.buttonCancelBooking.Text = "Återlämna";
            this.buttonCancelBooking.UseVisualStyleBackColor = false;
            this.buttonCancelBooking.Click += new System.EventHandler(this.buttonCancelBooking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(427, 303);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Är boken/böckerna återlämnade?";
            // 
            // dataGridViewInvoices
            // 
            this.dataGridViewInvoices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewInvoices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoices.Location = new System.Drawing.Point(22, 428);
            this.dataGridViewInvoices.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewInvoices.Name = "dataGridViewInvoices";
            this.dataGridViewInvoices.RowHeadersWidth = 72;
            this.dataGridViewInvoices.RowTemplate.Height = 37;
            this.dataGridViewInvoices.Size = new System.Drawing.Size(678, 131);
            this.dataGridViewInvoices.TabIndex = 12;
            // 
            // buttonPayInvoice
            // 
            this.buttonPayInvoice.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.buttonPayInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayInvoice.Location = new System.Drawing.Point(600, 572);
            this.buttonPayInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPayInvoice.Name = "buttonPayInvoice";
            this.buttonPayInvoice.Size = new System.Drawing.Size(100, 27);
            this.buttonPayInvoice.TabIndex = 13;
            this.buttonPayInvoice.Text = "OK";
            this.buttonPayInvoice.UseVisualStyleBackColor = false;
            this.buttonPayInvoice.Click += new System.EventHandler(this.buttonPayInvoice_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(384, 575);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Markera faktura som betald?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(22, 401);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Aktuella Fakturor";
            // 
            // ReturnApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonPayInvoice);
            this.Controls.Add(this.dataGridViewInvoices);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnApplication";
            this.Text = "ReturnApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewInvoices;
        private System.Windows.Forms.Button buttonPayInvoice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}