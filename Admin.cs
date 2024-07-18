using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void userSignUp_lb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var f = new Form1();
            f.Show();
            this.Close();
        }

        private void Sign_in_btn_admin_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            if (f.loginadmin(admin_username_txt.Text.ToString(), adminPassword_txt.Text.ToString()))
            {
                MessageBox.Show("Sign in successful", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var a = new admin_control();
                a.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Username or password ", "Sign in", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
    }
}
