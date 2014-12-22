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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!oldBox.Text.Equals(Properties.Settings.Default["password"]))
            {
                MessageBox.Show("The old password does not match!",
                    "Incorrect Password");
                oldBox.Focus();
            }
            else
            {
                if (newBox.Text == "")
                {
                    MessageBox.Show("Please enter a new password");
                    newBox.Focus();
                }
                else if (newBox.Text.Length < 6)
                {
                    MessageBox.Show("Minimum password length is 6 characters");
                    newBox.Focus();
                }
                else
                {
                    Properties.Settings.Default["password"] = newBox.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Password successfully updated");
                    this.Close();
                }
            }
        }
    }
}
