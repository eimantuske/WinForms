namespace pabandymas
{
    partial class SignUpform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpform));
            panel1 = new Panel();
            label2 = new Label();
            RepPassBox = new TextBox();
            pictureBox3 = new PictureBox();
            PasswordLable = new Label();
            UsernameLable = new Label();
            PassField = new TextBox();
            label3 = new Label();
            Loginbutton1 = new Button();
            LoginButton = new Button();
            pictureBox2 = new PictureBox();
            LoginField = new TextBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Azure;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RepPassBox);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(PasswordLable);
            panel1.Controls.Add(UsernameLable);
            panel1.Controls.Add(PassField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Loginbutton1);
            panel1.Controls.Add(LoginButton);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 580);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 320);
            label2.Name = "label2";
            label2.Size = new Size(244, 29);
            label2.TabIndex = 13;
            label2.Text = "Repeat Password";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RepPassBox
            // 
            RepPassBox.BackColor = SystemColors.Window;
            RepPassBox.Font = new Font("Microsoft Sans Serif", 12F);
            RepPassBox.Location = new Point(98, 353);
            RepPassBox.Name = "RepPassBox";
            RepPassBox.Size = new Size(244, 26);
            RepPassBox.TabIndex = 12;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(28, 320);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
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
            label3.Location = new Point(124, 523);
            label3.Name = "label3";
            label3.Size = new Size(138, 13);
            label3.TabIndex = 7;
            label3.Text = "Have account ?";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Loginbutton1
            // 
            Loginbutton1.BackColor = Color.AliceBlue;
            Loginbutton1.Cursor = Cursors.Hand;
            Loginbutton1.FlatStyle = FlatStyle.Flat;
            Loginbutton1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Loginbutton1.Location = new Point(124, 539);
            Loginbutton1.Name = "Loginbutton1";
            Loginbutton1.Size = new Size(138, 28);
            Loginbutton1.TabIndex = 6;
            Loginbutton1.Text = "Sign In";
            Loginbutton1.UseVisualStyleBackColor = false;
            Loginbutton1.Click += Loginbutton1_Click;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.AliceBlue;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginButton.Location = new Point(100, 476);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(199, 43);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Sign Up";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
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
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LoginField.Location = new Point(98, 182);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(244, 34);
            LoginField.TabIndex = 2;
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
            // SignUpform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 580);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SignUpform";
            StartPosition = FormStartPosition.CenterScreen;
            Load += SignUpform_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label PasswordLable;
        private Label UsernameLable;
        private TextBox PassField;
        private Label label3;
        private Button Loginbutton1;
        private Button LoginButton;
        private PictureBox pictureBox2;
        private TextBox LoginField;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox RepPassBox;
        private PictureBox pictureBox3;
    }
}