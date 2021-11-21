using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Ordering_Exercise
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "admin" && passworTextBox.Text == "admin")
            {
                new MainForm().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                nameTextBox.Clear();
                passworTextBox.Clear();
                nameTextBox.Focus();    
            }
        }

        private void clearLabel_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            passworTextBox.Clear();
            nameTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
