namespace pabandymas
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            PasswordLable = new Label();
            UsernameLable = new Label();
            PassField = new TextBox();
            label3 = new Label();
            SignUpbutton = new Button();
            LoginButton = new Button();
            pictureBox2 = new PictureBox();
            LoginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(PasswordLable);
            panel1.Controls.Add(UsernameLable);
            panel1.Controls.Add(PassField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(SignUpbutton);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 451);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // PasswordLable
            // 
            PasswordLable.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordLable.Location = new Point(98, 235);
            PasswordLable.Name = "PasswordLable";
            PasswordLable.Size = new Size(244, 29);
            PasswordLable.TabIndex = 10;
            PasswordLable.Text = "Password";
            PasswordLable.TextAlign = ContentAlignment.MiddleLeft;
            PasswordLable.Click += label2_Click_2;
            // 
            // UsernameLable
            // 
            UsernameLable.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UsernameLable.Location = new Point(98, 152);
            UsernameLable.Name = "UsernameLable";
            UsernameLable.Size = new Size(244, 23);
            UsernameLable.TabIndex = 9;
            UsernameLable.Text = "Username";
            UsernameLable.TextAlign = ContentAlignment.MiddleLeft;
            UsernameLable.Click += label2_Click_1;
            // 
            // PassField
            // 
            PassField.BackColor = SystemColors.Window;
            PassField.Font = new Font("Microsoft Sans Serif", 12F);
            PassField.Location = new Point(98, 268);
            PassField.Name = "PassField";
            PassField.Size = new Size(244, 26);
            PassField.TabIndex = 8;
            // 
            // label3
            // 
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(123, 395);
            label3.Name = "label3";
            label3.Size = new Size(138, 13);
            label3.TabIndex = 7;
            label3.Text = "Don't have account ?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // SignUpbutton
            // 
            SignUpbutton.BackColor = Color.AliceBlue;
            SignUpbutton.Cursor = Cursors.Hand;
            SignUpbutton.FlatStyle = FlatStyle.Flat;
            SignUpbutton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpbutton.Location = new Point(123, 411);
            SignUpbutton.Name = "SignUpbutton";
            SignUpbutton.Size = new Size(138, 28);
            SignUpbutton.TabIndex = 6;
            SignUpbutton.Text = "Sign Up";
            SignUpbutton.UseVisualStyleBackColor = false;
            SignUpbutton.Click += button3_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.AliceBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(98, 349);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(199, 43);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 235);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginField.Location = new Point(98, 182);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(244, 34);
            LoginField.TabIndex = 2;
            LoginField.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 152);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightCyan;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 100);
            panel2.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.SkyBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 77);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 100);
            label1.TabIndex = 0;
            label1.Text = "Spotify";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 451);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox LoginField;
        private PictureBox pictureBox2;
        private Button LoginButton;
        private Label label3;
        private Button SignUpbutton;
        private TextBox PassField;
        private Label UsernameLable;
        private Label PasswordLable;
    }
}