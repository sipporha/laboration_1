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
        //private readonly Main main;
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

            //main = Main.Start();

        }

        private void toolStripMenuBooking_Click(object sender, EventArgs e)
        {
            returnApplication.Hide();
            bookingApplication.Show();
            bookingApplication.Location = center;
        }

        private void toolStripMenuReturn_Click(object sender, EventArgs e)
        {
            bookingApplication.Hide();
            returnApplication.Show();
            returnApplication.Location = center;
        }
    }
}
