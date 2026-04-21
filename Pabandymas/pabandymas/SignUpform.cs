using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pabandymas
{
    public partial class SignUpform : Form
    {
        public SignUpform()
        {
            InitializeComponent();

            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(this.PassField.Size.Width, 32);
            this.PassField.UseSystemPasswordChar = true;

            this.RepPassBox.AutoSize = false;
            this.RepPassBox.Size = new Size(this.RepPassBox.Size.Width, 32);
            this.RepPassBox.UseSystemPasswordChar = true;
        }

        private void SignUpform_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Loginbutton1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            HomePage pagrindinis = new HomePage();

            pagrindinis.Show();

            this.Hide();
        }
    }
}
