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
        List<Bok> bokadeBöcker;
        readonly Main main;
        Medlem m;

        public BookingApplication()
        {
            InitializeComponent();
            bokadeBöcker = new List<Bok>();
            main = Main.Start();
            LaddaInnehåll();
        }
        public void LaddaInnehåll()
        {
            dataGridViewBook.DataSource = main.HämtaBok();
            dataGridViewBook.RowHeadersVisible = false;
            dataGridViewBook.Columns["Tillgänglig"].Visible = false;
            dataGridViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBook.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBook.MultiSelect = false;
            dataGridViewBook.AllowUserToResizeRows = false;
            dataGridViewBook.AllowUserToAddRows = false;

            dataGridViewMember.DataSource = main.HämtaMedlem();
            dataGridViewMember.Columns["Medlemsnummer"].Visible = false;
            dataGridViewMember.Columns["FullNamn"].Visible = false;
            dataGridViewMember.RowHeadersVisible = false;
            dataGridViewMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMember.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewMember.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMember.MultiSelect = false;
            dataGridViewMember.AllowUserToResizeRows = false;
            dataGridViewMember.AllowUserToAddRows = false;

            dataGridViewBooked.RowHeadersVisible = false;
            dataGridViewBooked.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBooked.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBooked.MultiSelect = false;
            dataGridViewBooked.AllowUserToResizeRows = false;
            dataGridViewBooked.AllowUserToAddRows = false;
        }

        public void UppdateraInnehåll()
        {
            List<Bok> TillgänligaBöcker = new List<Bok>();
            foreach (var item in main.HämtaBok())
            {
                if (item.Tillgänglig)
                {
                    TillgänligaBöcker.Add(item);
                }
            }
            dataGridViewBook.DataSource = TillgänligaBöcker;
        }

        private void buttonAddMember_Click(object sender, EventArgs e)
        {
            if (dataGridViewMember.SelectedRows.Count==0)
            {
                return;
            }
            DataGridViewRow valdLåntagare = dataGridViewMember.SelectedRows[0];
            m = (Medlem)valdLåntagare.DataBoundItem;
            textBoxLoaner.DataBindings.Clear();
            textBoxLoaner.DataBindings.Add("Text",m, "FullNamn");
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow valdBok = dataGridViewBook.SelectedRows[0];
            Bok b = (Bok)valdBok.DataBoundItem;
            
            if (!bokadeBöcker.Contains(b))
            {
                bokadeBöcker.Add(b);
            }
            var bindingList = new BindingList<Bok>(bokadeBöcker);
            var source = new BindingSource(bindingList, null);
            dataGridViewBooked.DataSource = source;
            LaddaInnehåll();
            //TODO: fixa till sen så att view blir snyggare...
            dataGridViewBooked.Columns["Tillgänglig"].Visible = false;

        }


        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            if (m==null)
            {
                MessageBox.Show("Användare ej vald...");
                return;
            }

            foreach (var item in bokadeBöcker)
            {
                main.LäggTillBokning(item, m);
                item.Tillgänglig = false;
            }
            MessageBox.Show("Skiten är sparad...","Grattis!");
            dataGridViewBooked.Rows.Clear();
            textBoxLoaner.Clear();
            m = null;
            UppdateraInnehåll();
            
        }
        
    }
}
