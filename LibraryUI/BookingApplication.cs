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

            //TODO: fixa till sen så att view blir snyggare...
        }

        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            foreach (var item in bokadeBöcker)
            {
                main.LäggTillBokning(new Bokning(item, m,DateTime.Now,DateTime.Now.AddDays(30)));
                item.Tillgänglig = false;
            }
        }

    }
}
