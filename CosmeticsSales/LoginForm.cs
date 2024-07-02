using System;
using System.Windows.Forms;

namespace CosmeticsSales
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // For simplicity, hardcoding a username and password
            string username = "admin";
            string password = "password";

            if (txtUsername.Text == username && txtPassword.Text == password)
            {
                MessageBox.Show("Login successful");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
    }
}
