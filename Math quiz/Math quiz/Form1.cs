namespace Math_quiz
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        int addent1;
        int addent2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        public Form1()
        {
            InitializeComponent();
        }

        public void startTheQuiz()
        {
            addent1 = random.Next(51);
            addent2 = random.Next(51);

            plusLlabel.Text = addent1.ToString();
            plusRlabel.Text = addent2.ToString();

            sum.Value = 0;

            minuend = random.Next(1, 101);
            subtrahend = random.Next(1, minuend);
            minusLlabel.Text = minuend.ToString();
            minusRlabel.Text = subtrahend.ToString();
            difference.Value = 0;

            multiplicand = random.Next(2, 11);
            multiplier = random.Next(2, 11);
            timesLlabel.Text = multiplicand.ToString();
            timesRlabel.Text = multiplier.ToString();
            product.Value = 0;

            divisor = random.Next(2, 11);
            int temporaryQuotient = random.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLlabel.Text = dividend.ToString();
            dividedRlabel.Text = divisor.ToString();
            quotient.Value = 0;

            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer.Start();
        }
        private void startButton_Click(object sender, EventArgs e)
        {
            startTheQuiz();
            Startquiz.Enabled = false;
        }
        private bool CheckTheAnswer()
        {
            if ((addent1 + addent2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                Startquiz.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";

                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
            }
            else
            {
                timer.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addent1 + addent2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                Startquiz.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown atsakymas = sender as NumericUpDown;

            if (atsakymas != null)
            {
                int lengthOfAnswer = atsakymas.Value.ToString().Length;
                atsakymas.Select(0, lengthOfAnswer);
            }
        }
    }
}

