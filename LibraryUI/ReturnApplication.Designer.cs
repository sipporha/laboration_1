
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonPayInvoice = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avsluta bokning";
            // 
            // dataGridViewBooking
            // 
            this.dataGridViewBooking.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewBooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBooking.Location = new System.Drawing.Point(38, 242);
            this.dataGridViewBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewBooking.Name = "dataGridViewBooking";
            this.dataGridViewBooking.RowHeadersWidth = 72;
            this.dataGridViewBooking.RowTemplate.Height = 37;
            this.dataGridViewBooking.Size = new System.Drawing.Size(1073, 344);
            this.dataGridViewBooking.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Aktuella bokningar";
            // 
            // buttonCancelBooking
            // 
            this.buttonCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonCancelBooking.Location = new System.Drawing.Point(38, 701);
            this.buttonCancelBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelBooking.Name = "buttonCancelBooking";
            this.buttonCancelBooking.Size = new System.Drawing.Size(188, 54);
            this.buttonCancelBooking.TabIndex = 9;
            this.buttonCancelBooking.Text = "Avsluta bokning";
            this.buttonCancelBooking.UseVisualStyleBackColor = false;
            this.buttonCancelBooking.Click += new System.EventHandler(this.buttonCancelBooking_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 652);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "Är boken/böckerna återlämnade?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 920);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1073, 262);
            this.dataGridView1.TabIndex = 12;
            // 
            // buttonPayInvoice
            // 
            this.buttonPayInvoice.Location = new System.Drawing.Point(940, 1206);
            this.buttonPayInvoice.Name = "buttonPayInvoice";
            this.buttonPayInvoice.Size = new System.Drawing.Size(171, 54);
            this.buttonPayInvoice.TabIndex = 13;
            this.buttonPayInvoice.Text = "OK";
            this.buttonPayInvoice.UseVisualStyleBackColor = true;
            this.buttonPayInvoice.Click += new System.EventHandler(this.buttonPayInvoice_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1498, 920);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 59);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(570, 1213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 37);
            this.label4.TabIndex = 15;
            this.label4.Text = "Markera faktura som betald?";
            // 
            // ReturnApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1391);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonPayInvoice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCancelBooking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewBooking);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReturnApplication";
            this.Text = "ReturnApplication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBooking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewBooking;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCancelBooking;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonPayInvoice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}