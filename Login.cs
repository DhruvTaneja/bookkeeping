using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Diwas_Taneja
{
    public partial class Login : Form
    {

        public bool validate = false;

        public Login()
        {
            InitializeComponent();
            forgotLabel.Text = "Forgot password? Contact the developer.";
            forgotLabel.ForeColor = Color.Red;
            forgotLabel.Visible = false;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string pass = passwordBox.Text;
            if(pass.Equals(Properties.Settings.Default["password"]))
            {
                validate = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("The password is incorrect", "Wrong Password");
                validate = false;
                forgotLabel.Visible = true;
                passwordBox.Focus();
            }
        }

        public bool getSuccess()
        {
            return validate;
        }
    }
}
