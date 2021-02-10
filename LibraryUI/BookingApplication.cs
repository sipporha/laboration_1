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
            UppdateraInnehåll();
        }
        public void LaddaInnehåll()
        {
            dataGridViewBook.DataSource = main.HämtaBok();
            dataGridViewBook.RowHeadersVisible = false;
            dataGridViewBook.Columns["Tillgänglig"].Visible = false;
            dataGridViewBook.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewBook.Columns["Titel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewBook.MultiSelect = false;
            dataGridViewBook.AllowUserToResizeRows = false;
            dataGridViewBook.AllowUserToAddRows = false;

            dataGridViewMember.DataSource = main.HämtaMedlem();
            dataGridViewMember.Columns["Medlemsnummer"].Visible = false;
            dataGridViewMember.Columns["FullNamn"].Visible = false;
            dataGridViewMember.RowHeadersVisible = false;
            dataGridViewMember.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewMember.Columns["Epost"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

            labelLåntagareFail.Text = "";
            labelFailBok.Text = "";
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
            textBoxLoaner.Text = "";
            labelFailBok.Text = "";
            labelLåntagareFail.Text = "";
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
            dataGridViewBooked.Columns["Tillgänglig"].Visible = false;
            dataGridViewBooked.Columns["Titel"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        /// <summary>
        /// Metoden skapar en ny bokning med en kund och ett antal böcker.
        /// Böckerna status ändras till otillgängliga ända tills dess att de returneras.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddBooking_Click(object sender, EventArgs e)
        {
            if (m==null)
            {
                labelLåntagareFail.Text="Du måste välja användare!";   
                return;
            }
            
            if (bokadeBöcker.Count == 0)
            {
                labelFailBok.Text = "Du måste välja en bok!";
                return;
            }

            foreach (var item in bokadeBöcker)
            {
                main.LäggTillBokning(item, m);
                item.Tillgänglig = false;
            }

            labelLåntagareFail.Text="";
            labelFailBok.Text = "";
            MessageBox.Show("Bokning är sparad!","Meddelande");
            dataGridViewBooked.Rows.Clear();  
            m = null;
            UppdateraInnehåll();
            textBoxLoaner.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
