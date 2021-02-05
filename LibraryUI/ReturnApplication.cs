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
            dataGridViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBooking.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
