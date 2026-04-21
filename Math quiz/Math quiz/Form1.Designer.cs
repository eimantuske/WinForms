namespace Math_quiz
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timeLabel = new Label();
            Timelable = new Label();
            plusLlabel = new Label();
            plus = new Label();
            plusRlabel = new Label();
            equalsign = new Label();
            sum = new NumericUpDown();
            difference = new NumericUpDown();
            label1 = new Label();
            minusRlabel = new Label();
            minus = new Label();
            minusLlabel = new Label();
            product = new NumericUpDown();
            label5 = new Label();
            timesRlabel = new Label();
            label7 = new Label();
            timesLlabel = new Label();
            quotient = new NumericUpDown();
            label9 = new Label();
            dividedRlabel = new Label();
            divided = new Label();
            dividedLlabel = new Label();
            Startquiz = new Button();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)sum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)difference).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quotient).BeginInit();
            SuspendLayout();
            // 
            // timeLabel
            // 
            timeLabel.BorderStyle = BorderStyle.Fixed3D;
            timeLabel.Font = new Font("Segoe UI", 15.75F);
            timeLabel.Location = new Point(272, 9);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(200, 30);
            timeLabel.TabIndex = 0;
            timeLabel.UseMnemonic = false;
            // 
            // Timelable
            // 
            Timelable.AutoSize = true;
            Timelable.Font = new Font("Segoe UI", 15.75F);
            Timelable.Location = new Point(167, 9);
            Timelable.Name = "Timelable";
            Timelable.Size = new Size(99, 30);
            Timelable.TabIndex = 1;
            Timelable.Text = "Time Left";
            // 
            // plusLlabel
            // 
            plusLlabel.Font = new Font("Segoe UI", 18F);
            plusLlabel.Location = new Point(50, 75);
            plusLlabel.Name = "plusLlabel";
            plusLlabel.Size = new Size(60, 50);
            plusLlabel.TabIndex = 2;
            plusLlabel.Text = "?";
            plusLlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plus
            // 
            plus.Font = new Font("Segoe UI", 18F);
            plus.Location = new Point(116, 75);
            plus.Name = "plus";
            plus.Size = new Size(60, 50);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // plusRlabel
            // 
            plusRlabel.Font = new Font("Segoe UI", 18F);
            plusRlabel.Location = new Point(182, 75);
            plusRlabel.Name = "plusRlabel";
            plusRlabel.Size = new Size(60, 50);
            plusRlabel.TabIndex = 4;
            plusRlabel.Text = "?";
            plusRlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // equalsign
            // 
            equalsign.Font = new Font("Segoe UI", 18F);
            equalsign.Location = new Point(248, 75);
            equalsign.Name = "equalsign";
            equalsign.Size = new Size(60, 50);
            equalsign.TabIndex = 5;
            equalsign.Text = "=";
            equalsign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            sum.Font = new Font("Segoe UI", 18F);
            sum.Location = new Point(314, 82);
            sum.MaximumSize = new Size(100, 0);
            sum.Name = "sum";
            sum.Size = new Size(100, 39);
            sum.TabIndex = 1;
            sum.Enter += answer_Enter;
            // 
            // difference
            // 
            difference.Font = new Font("Segoe UI", 18F);
            difference.Location = new Point(314, 132);
            difference.MaximumSize = new Size(100, 0);
            difference.Name = "difference";
            difference.Size = new Size(100, 39);
            difference.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(248, 125);
            label1.Name = "label1";
            label1.Size = new Size(60, 50);
            label1.TabIndex = 10;
            label1.Text = "=";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusRlabel
            // 
            minusRlabel.Font = new Font("Segoe UI", 18F);
            minusRlabel.Location = new Point(182, 125);
            minusRlabel.Name = "minusRlabel";
            minusRlabel.Size = new Size(60, 50);
            minusRlabel.TabIndex = 9;
            minusRlabel.Text = "?";
            minusRlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minus
            // 
            minus.Font = new Font("Segoe UI", 18F);
            minus.Location = new Point(116, 125);
            minus.Name = "minus";
            minus.Size = new Size(60, 50);
            minus.TabIndex = 8;
            minus.Text = "-";
            minus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // minusLlabel
            // 
            minusLlabel.Font = new Font("Segoe UI", 18F);
            minusLlabel.Location = new Point(50, 125);
            minusLlabel.Name = "minusLlabel";
            minusLlabel.Size = new Size(60, 50);
            minusLlabel.TabIndex = 7;
            minusLlabel.Text = "?";
            minusLlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            product.Font = new Font("Segoe UI", 18F);
            product.Location = new Point(314, 182);
            product.MaximumSize = new Size(100, 0);
            product.Name = "product";
            product.Size = new Size(100, 39);
            product.TabIndex = 3;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 18F);
            label5.Location = new Point(248, 175);
            label5.Name = "label5";
            label5.Size = new Size(60, 50);
            label5.TabIndex = 15;
            label5.Text = "=";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesRlabel
            // 
            timesRlabel.Font = new Font("Segoe UI", 18F);
            timesRlabel.Location = new Point(182, 175);
            timesRlabel.Name = "timesRlabel";
            timesRlabel.Size = new Size(60, 50);
            timesRlabel.TabIndex = 14;
            timesRlabel.Text = "?";
            timesRlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 18F);
            label7.Location = new Point(116, 175);
            label7.Name = "label7";
            label7.Size = new Size(60, 50);
            label7.TabIndex = 13;
            label7.Text = "*";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timesLlabel
            // 
            timesLlabel.Font = new Font("Segoe UI", 18F);
            timesLlabel.Location = new Point(50, 175);
            timesLlabel.Name = "timesLlabel";
            timesLlabel.Size = new Size(60, 50);
            timesLlabel.TabIndex = 12;
            timesLlabel.Text = "?";
            timesLlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quotient
            // 
            quotient.Font = new Font("Segoe UI", 18F);
            quotient.Location = new Point(314, 232);
            quotient.MaximumSize = new Size(100, 0);
            quotient.Name = "quotient";
            quotient.Size = new Size(100, 39);
            quotient.TabIndex = 4;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 18F);
            label9.Location = new Point(248, 225);
            label9.Name = "label9";
            label9.Size = new Size(60, 50);
            label9.TabIndex = 20;
            label9.Text = "=";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedRlabel
            // 
            dividedRlabel.Font = new Font("Segoe UI", 18F);
            dividedRlabel.Location = new Point(182, 225);
            dividedRlabel.Name = "dividedRlabel";
            dividedRlabel.Size = new Size(60, 50);
            dividedRlabel.TabIndex = 19;
            dividedRlabel.Text = "?";
            dividedRlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // divided
            // 
            divided.Font = new Font("Segoe UI", 18F);
            divided.Location = new Point(116, 225);
            divided.Name = "divided";
            divided.Size = new Size(60, 50);
            divided.TabIndex = 18;
            divided.Text = "/";
            divided.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dividedLlabel
            // 
            dividedLlabel.Font = new Font("Segoe UI", 18F);
            dividedLlabel.Location = new Point(50, 225);
            dividedLlabel.Name = "dividedLlabel";
            dividedLlabel.Size = new Size(60, 50);
            dividedLlabel.TabIndex = 17;
            dividedLlabel.Text = "?";
            dividedLlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Startquiz
            // 
            Startquiz.AutoSize = true;
            Startquiz.Font = new Font("Segoe UI", 14F);
            Startquiz.Location = new Point(176, 314);
            Startquiz.Name = "Startquiz";
            Startquiz.Size = new Size(133, 35);
            Startquiz.TabIndex = 0;
            Startquiz.Text = "Start the quiz";
            Startquiz.UseVisualStyleBackColor = true;
            Startquiz.Click += startButton_Click;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(Startquiz);
            Controls.Add(quotient);
            Controls.Add(label9);
            Controls.Add(dividedRlabel);
            Controls.Add(divided);
            Controls.Add(dividedLlabel);
            Controls.Add(product);
            Controls.Add(label5);
            Controls.Add(timesRlabel);
            Controls.Add(label7);
            Controls.Add(timesLlabel);
            Controls.Add(difference);
            Controls.Add(label1);
            Controls.Add(minusRlabel);
            Controls.Add(minus);
            Controls.Add(minusLlabel);
            Controls.Add(sum);
            Controls.Add(equalsign);
            Controls.Add(plusRlabel);
            Controls.Add(plus);
            Controls.Add(plusLlabel);
            Controls.Add(Timelable);
            Controls.Add(timeLabel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)sum).EndInit();
            ((System.ComponentModel.ISupportInitialize)difference).EndInit();
            ((System.ComponentModel.ISupportInitialize)product).EndInit();
            ((System.ComponentModel.ISupportInitialize)quotient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label timeLabel;
        private Label Timelable;
        private Label plusLlabel;
        private Label plus;
        private Label plusRlabel;
        private Label equalsign;
        private NumericUpDown sum;
        private NumericUpDown difference;
        private Label label1;
        private Label minusRlabel;
        private Label minus;
        private Label minusLlabel;
        private NumericUpDown product;
        private Label label5;
        private Label timesRlabel;
        private Label label7;
        private Label timesLlabel;
        private NumericUpDown quotient;
        private Label label9;
        private Label dividedRlabel;
        private Label divided;
        private Label dividedLlabel;
        private Button Startquiz;
        private System.Windows.Forms.Timer timer;
    }
}
