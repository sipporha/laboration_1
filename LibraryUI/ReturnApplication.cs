using LibraryBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBooking.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBooking.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooking.MultiSelect = false;
            dataGridViewBooking.AllowUserToResizeRows = false;
            dataGridViewBooking.AllowUserToAddRows = false;
        }

        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewBooking.CurrentRow;

            foreach (var item in main.HämtaBokning())
            {
                if (item.Bok.ISBN == Convert.ToInt32(selectedRow.Cells["ISBN"].Value.ToString()))

                {
                    item.Återlämnad = true;
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
    }
}
