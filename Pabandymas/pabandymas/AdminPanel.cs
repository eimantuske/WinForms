using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pabandymas
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private static object GetDebuggerDisplay()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
         
        private void button2_Click(object sender, EventArgs e)
        {
            SignUpform signUpForm = new SignUpform();
            signUpForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           HomePage pagrindinis = new HomePage();
            pagrindinis.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nd namudarbas = new Nd();
            namudarbas.Show();
            
        }
    }
}
