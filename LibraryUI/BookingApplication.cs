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
            dataGridViewBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBook.MultiSelect = false;
            dataGridViewBook.AllowUserToResizeRows = false;
            dataGridViewBook.AllowUserToAddRows = false;

            dataGridViewMember.DataSource = main.HämtaMedlem();
            dataGridViewMember.Columns["Medlemsnummer"].Visible = false;
            dataGridViewMember.RowHeadersVisible = false;
            dataGridViewMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMember.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMember.MultiSelect = false;
            dataGridViewMember.AllowUserToResizeRows = false;
            dataGridViewMember.AllowUserToAddRows = false;
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow valdLåntagare = dataGridViewMember.SelectedRows[0];
            Medlem m = (Medlem)valdLåntagare.DataBoundItem;
            textBoxLoaner.DataBindings.Clear();
            textBoxLoaner.DataBindings.Add("Text",m,"FullNamn");
        }


        private void buttonAddBooking_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {

        }
    }
}
