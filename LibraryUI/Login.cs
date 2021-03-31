using System;
using LibraryBL.Internal;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryBL;

namespace LibraryUI
{
    public partial class Login : Form
    {
        private Main main;

        public Login()
        {
            main = Main.Start();
            InitializeComponent();
            labelFelInput.Text = "";
        }

        private void Login_Load(object sender, EventArgs e) { }
        
        /// <summary>
        /// Loggar in en användare i systemet förutsatt att man skriver rätt inloggningsuppgifter.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == "" && textBoxPassword.Text == "")
            {
                labelFelInput.Text = "Fält får inte lämnas tomma.";
                return;
            }

            int x;
            if (!Int32.TryParse(textBoxUsername.Text, out x))
            {
                labelFelInput.Text = "Inga bokstäver tillåtna!";
                return;
            }

            if (main.LoggaIn(textBoxUsername.Text, textBoxPassword.Text))
            {
                LibraryApplication libraryApplication = new LibraryApplication();
                libraryApplication.Show();
                this.Hide();
            }
            else
            {
                labelFelInput.Text = "Lösenordet och/eller användarnamn var fel!";
            }
        }
    }
}
