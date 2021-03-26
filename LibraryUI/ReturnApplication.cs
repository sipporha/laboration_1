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
            dataGridViewBooking.DataSource = main.HämtaBokningar();
            dataGridViewBooking.RowHeadersVisible = false;
            dataGridViewBooking.Columns["Bok"].Visible = false;
            dataGridViewBooking.Columns["Medlem"].Visible = false;
            dataGridViewBooking.Columns["Faktura"].Visible = false;
            dataGridViewBooking.Columns["Återlämnad"].Visible = false;
            dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBooking.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooking.MultiSelect = false;
            dataGridViewBooking.AllowUserToResizeRows = false;
            dataGridViewBooking.AllowUserToAddRows = false;


            dataGridViewInvoices.DataSource = main.HämtaFaktura();
            dataGridViewInvoices.RowHeadersVisible = false;
            dataGridViewInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewInvoices.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewInvoices.Columns[0].Visible = false;
            dataGridViewInvoices.MultiSelect = false;
            dataGridViewInvoices.AllowUserToResizeRows = false;
            dataGridViewInvoices.AllowUserToAddRows = false;
            foreach (DataGridViewRow row in dataGridViewInvoices.Rows)
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

        /// <summary>
        /// Letar upp bokningar och tar bort den bokning en användaren markerar och väljer att ta bort.
        /// Bokens status ändras till tillgänglig och går att på nytt bokas.
        /// Om bokningen återlämnas för sent skapas en faktura som adderar 10:-/dag som går över slutdatumet för bokningen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewBooking.CurrentRow;
            foreach (var item in main.HämtaBokningar())
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
                            MessageBox.Show("Bokningen var försenad och en faktura har skapats.", "Reprimand!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            main.SkapaFaktura(item, x);
                        }
                    }
                    MessageBox.Show("Boken är återlämnad", "Notis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } 
            dataGridViewBooking.DataSource = typeof(List<Bokning>);
            LaddaInnehåll();
        }

        /// <summary>
        /// Om en faktura är obetald, kan användaren välja att markera fakturan som betald och fakturans återstående
        /// summa ställs till 0.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPayInvoice_Click(object sender, EventArgs e)
        {
            DataGridViewRow valdFaktura = dataGridViewInvoices.SelectedRows[0];
            Faktura f = (Faktura)valdFaktura.DataBoundItem;
            if (f.ÅterståendeSumma == 0)
            {
                MessageBox.Show("Fakturan är redan betald!", "Notis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                f.ÅterståendeSumma = 0;
                MessageBox.Show("Betalningen lyckades!", "Notis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LaddaInnehåll();
        }
    }
}
