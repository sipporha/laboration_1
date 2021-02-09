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
    public partial class LibraryApplication : Form
    {
        BookingApplication bookingApplication;
        ReturnApplication returnApplication;
        Point center = new Point(0, 0);

        public LibraryApplication()
        {
            InitializeComponent();
            bookingApplication = new BookingApplication();
            bookingApplication.MdiParent = this;
            bookingApplication.Show();

            returnApplication = new ReturnApplication();
            returnApplication.MdiParent = this;
        }

        private void toolStripMenuBooking_Click(object sender, EventArgs e)
        {
            returnApplication.Hide();
            bookingApplication.Show();
            bookingApplication.Location = center;
            bookingApplication.UppdateraInnehåll();
        }

        private void toolStripMenuReturn_Click(object sender, EventArgs e)
        {
            bookingApplication.Hide();
            returnApplication.Show();
            returnApplication.Location = center;
            returnApplication.UppdateraInnehåll();
        }

        private void LibraryApplication_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (MessageBox.Show("Är du säker på att du vill avsluta?", "Bekräfta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // user clicked yes
                Application.Exit();
            }
            return;
            //TODO: Om jag orkar en messagebox med val...
            
        }
    }
}
