using LibraryBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LibraryUI
{
    public partial class ReturnApplication : Form
    {
        Main main;

        public ReturnApplication()
        {
            main = Main.Start();
            InitializeComponent();
            LaddaInnehåll();
        }

        public void LaddaInnehåll()
        {
            dataGridViewBooking.DataSource = main.HämtaBokning();
            dataGridViewBooking.RowHeadersVisible = false;
            dataGridViewBooking.Columns["Bok"].Visible = false;
            dataGridViewBooking.Columns["Medlem"].Visible = false;
            dataGridViewBooking.Columns["Faktura"].Visible = false;
            dataGridViewBooking.Columns["Återlämnad"].Visible = false;
            dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBooking.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooking.MultiSelect = false;
            dataGridViewBooking.AllowUserToResizeRows = false;
            dataGridViewBooking.AllowUserToAddRows = false;


            dataGridView1.DataSource = main.HämtaFaktura();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if((double)row.Cells[5].Value == 0)
                {
                    row.DefaultCellStyle.ForeColor = Color.LightGray;
                }
            }

        }
        public void UppdateraInnehåll()
        {
            dataGridViewBooking.DataSource = typeof(List<Bokning>);
            LaddaInnehåll();
        }


        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewBooking.CurrentRow;

            foreach (var item in main.HämtaBokning())
            {
                if (item.Bok.ISBN == Convert.ToInt32(selectedRow.Cells["ISBN"].Value.ToString()))

                {
                    item.Återlämnad = true;
                    item.Bok.Tillgänglig = true;
                    if (DateTime.Now>item.Sluttid)
                    {
                        double x = Math.Floor((DateTime.Now.Date-item.Sluttid).TotalDays * 10);
                        if (x>0)
                        {
                            MessageBox.Show("Du får betala " + x + "kr.");
                            main.SkapaFaktura(item, x);
                        }
                        
                  
                    }
                }
            }
            dataGridViewBooking.DataSource = typeof(List<Bokning>);
            LaddaInnehåll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewBooking.DataSource = typeof(List<Bokning>);
            LaddaInnehåll();
        }

        private void buttonPayInvoice_Click(object sender, EventArgs e)
        {
            DataGridViewRow valdFaktura = dataGridView1.SelectedRows[0];
            Faktura f = (Faktura)valdFaktura.DataBoundItem;
            f.ÅterståendeSumma = 0;
            LaddaInnehåll();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LaddaInnehåll();
        }
    }
}
