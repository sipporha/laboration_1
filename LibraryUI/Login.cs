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
        }

        private void Login_Load(object sender, EventArgs e) { }
        

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // För att slippa logga in hela tiden, tas bort sedan
            LibraryApplication libraryApplication = new LibraryApplication();
            libraryApplication.Show();
            this.Hide();
             
            /* 
           //Lägga till med tryparse istället.
            foreach (char item in textBoxUsername.Text)
            {
                if (!Char.IsDigit(item))
                {
                    labelFelInput.Text = "Inga bokstäver tillåtna!";
                    return;
                }
            }
            if (textBoxUsername.Text == "" && textBoxPassword.Text == "")
            {
                labelFelInput.Text = "Fält får inte lämnas tomma.";
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
        
          */
        }
    }
}
