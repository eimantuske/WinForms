using System;
using System.Windows.Forms;

namespace pabandymas
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
         
            this.KeyPreview = true;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.Shift && e.KeyCode == Keys.D)
            {
                e.SuppressKeyPress = true;

                AdminPanel admin = new AdminPanel();
                admin.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nd namudarbas = new Nd();
            namudarbas.Show();
            this.Hide();

        }
    }
}