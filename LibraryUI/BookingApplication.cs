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
    public partial class BookingApplication : Form
    {
        readonly Main main;
        public BookingApplication()
        {
            InitializeComponent();
            main = Main.Start();
            LaddaInnehåll();
        }
        public void LaddaInnehåll()
        {
            dataGridViewBook.DataSource = main.HämtaBok();
            dataGridViewBook.RowHeadersVisible = false;
            dataGridViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridViewMember.DataSource = main.HämtaMedlem();
            dataGridViewMember.Columns["Medlemsnummer"].Visible = false;
            dataGridViewMember.RowHeadersVisible = false;
            dataGridViewMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMember.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
