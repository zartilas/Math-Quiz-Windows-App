using FinalErgasia2.Classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FinalErgasia2
{
    public partial class Game : Form
    {
        private int counter = 120;
        private int playingDuration = 0;
        private bool finishedGame = false;
        private int count = 0;

        //Stats
        private int grade = 0;
        private string finishedBeforeCountdown = "Yes";
        private int wrongAnswers = 0;

        public Random rndm = new Random();

        private string addition;
        private string subtraction;
        private string multiplication;
        private string division;

        public Game()
        {
            InitializeComponent();
        }

        public void stopGame()
        {
            int correctAnswers = 0;
            foreach (var textboxes in new TextBox[]
            {
                textboxMultiplicationAns,
                textboxSubtractionAns,
                textboxAdditionAns,
                textboxDivisionAns
            })
            {
                if (textboxes.ReadOnly == true) { correctAnswers++; }
                if (correctAnswers == 4)
                {
                    grade = grade + 50;
                    if (grade < 0) { grade = 0; } else if (grade > 100) { grade = 100; }
                    timer_Countdown.Stop();
                    finishedGame = true;
                    if (finishedBeforeCountdown == "Yes") { grade = grade + 50; }
                    FinalMessage finalMsg = new FinalMessage();
                    DialogResult dialog = MessageBox.Show(finalMsg.dialogResult(grade, finishedBeforeCountdown, wrongAnswers, playingDuration), "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                    timer_Countdown.Stop();
                    timer_Playing_Duration.Stop();
                    if (dialog == DialogResult.OK)
                    {
                        this.Hide();
                        this.Close();
                        Main main = new Main();
                        main.ShowDialog();
                    }
                    return;
                }
            }
        }

        private void timer_Playing_Duration_Tick(object sender, EventArgs e)
        {
            playingDuration++;
            if (finishedBeforeCountdown == "No")
            {
                count++;
                if (count == 30)
                {
                    grade = grade - 5;
                    count = 0;
                }
            }
        }

        private void timergame_Tick(object sender, EventArgs e)
        {
            labelTime.Text = string.Format("{0:00}:{1:00}", (counter / 60) % 60, counter % 60);
            if (counter <= 120 && counter >= 61)
            {
                labelTime.ForeColor = Color.Green;
            }
            else if (counter <= 60 && counter >= 31)
            {
                labelTime.ForeColor = Color.Yellow;
            }
            else if (counter <= 30 && counter >= 1)
            {
                labelTime.ForeColor = Color.Red;
            }
            else if (counter == 0)
            {
                timer_Countdown.Stop();
                finishedBeforeCountdown = "No";
                button_Calculator.Visible = true;
                return;
            }
            counter--;
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer_Countdown.Stop();
            if (finishedGame == false)
            {
                this.Hide();
                DialogResult dialog = MessageBox.Show("Are you sure you want to leave the game?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog != DialogResult.Yes)
                {
                    e.Cancel = true;
                    timer_Countdown.Start();
                    this.Show();
                }
                else
                {
                    Main main = new Main();
                    main.ShowDialog();
                }
            }
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            if (Calculator.helps == 2)
            {
                MsgBox msgBox = new MsgBox();
                msgBox.Msg();
                return;
            }
            calc.Show();
        }

        private void textBoxAnswers_KeyDown(object sender, KeyEventArgs e)
        {
            //Apenergopioisi tou paste (Ctrl + V).
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void textBoxAnswers_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Auto tha apotrepsei ton xristi na xrisimopisi space & allous xaraktires.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer_Countdown.Enabled = true;
            timer_Playing_Duration.Enabled = true;

            addition = rndm.Next(1, 50) + "   +   " + rndm.Next(1, 49);
            labelAddition.Text = addition;

            subtraction = rndm.Next(50, 99) + "   -   " + rndm.Next(1, 49);
            labelSubtraction.Text = subtraction;

            multiplication = rndm.Next(1, 31) + "   *   " + rndm.Next(1, 31);
            labelMultiplication.Text = multiplication.Replace("*", "x");

            int divFirstNumber = rndm.Next(1, 99);
            int divSecondNumber = rndm.Next(1, 99);
            division = divFirstNumber + "   /   " + divSecondNumber;
            while (divFirstNumber % divSecondNumber != 0)
            {
                divFirstNumber = rndm.Next(1, 99);
                divSecondNumber = rndm.Next(1, 99);
                division = divFirstNumber + "   /   " + divSecondNumber;
            }
            labelDivision.Text = division.Replace("/", "÷");

            
            //Emfanizoume ta koumpia
            timer_Countdown.Start();
            timer_Playing_Duration.Start();

            button_Start.Visible = false;
            labelTimeLeft.Visible = true;
            labelTime.Visible = true;
            button_Check.Visible = true;

            foreach (var l in new Label[]
            {
              labelAddition,
              labelSubtraction,
              labelMultiplication,
              labelDivision,
              labelAdditionResult,
              labelSubtractionResult,
              labelMultiplicationResult,
              labelDivisionResult
            }) l.Visible = true;

            foreach (var t in new TextBox[]
            {
              textboxAdditionAns,
              textboxSubtractionAns,
              textboxMultiplicationAns,
              textboxDivisionAns
            }) t.Visible = true;
        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            int result = Convert.ToInt32(new DataTable().Compute(addition, null));
            if (textboxAdditionAns.Text != "")
            {
                if (Int32.Parse(textboxAdditionAns.Text) == result)
                {
                    pictureBoxAddition.Visible = true;
                    pictureBoxAddition.Image = Properties.Resources.Correct;
                    textboxAdditionAns.ReadOnly = true;
                    textboxAdditionAns.BackColor = Color.FromArgb(28, 161, 0);
                    foreach (var textboxes in new TextBox[]
                    {
                        textboxDivisionAns,
                        textboxMultiplicationAns,
                        textboxSubtractionAns
                    }) { if (textboxes.ReadOnly != true) { textboxes.Select(); } }
                }
                else
                {
                    pictureBoxAddition.Visible = true;
                    pictureBoxAddition.Image = Properties.Resources.Wrong;
                    textboxAdditionAns.BackColor = Color.FromArgb(255, 247, 0);
                    wrongAnswers++;
                    grade = grade - 5;
                }
            }
            else
            {
                pictureBoxAddition.Visible = false;
                textboxAdditionAns.BackColor = Color.WhiteSmoke;
            }
            //Aferesi
            result = Convert.ToInt32(new DataTable().Compute(subtraction, null));
            if (textboxSubtractionAns.Text != "")
            {
                if (Int32.Parse(textboxSubtractionAns.Text) == result)
                {
                    pictureBoxSubtraction.Visible = true;
                    pictureBoxSubtraction.Image = Properties.Resources.Correct;
                    textboxSubtractionAns.ReadOnly = true;
                    textboxSubtractionAns.BackColor = Color.FromArgb(28, 161, 0);
                    foreach (var textboxes in new TextBox[]
                    {
                        textboxAdditionAns,
                        textboxDivisionAns,
                        textboxMultiplicationAns
                    }) { if (textboxes.ReadOnly != true) { textboxes.Select(); } }
                }
                else
                {
                    pictureBoxSubtraction.Visible = true;
                    pictureBoxSubtraction.Image = Properties.Resources.Wrong;
                    textboxSubtractionAns.BackColor = Color.FromArgb(255, 247, 0);
                    wrongAnswers++;
                    grade = grade - 5;
                }
            }
            else
            {
                pictureBoxSubtraction.Visible = false;
                textboxSubtractionAns.BackColor = Color.WhiteSmoke;
            }
            //Pollaplasiasmos
            result = Convert.ToInt32(new DataTable().Compute(multiplication, null));
            if (textboxMultiplicationAns.Text != "")
            {
                if (Int32.Parse(textboxMultiplicationAns.Text) == result)
                {
                    pictureBoxMultiplication.Visible = true;
                    pictureBoxMultiplication.Image = Properties.Resources.Correct;
                    textboxMultiplicationAns.ReadOnly = true;
                    textboxMultiplicationAns.BackColor = Color.FromArgb(28, 161, 0);
                    foreach (var textboxes in new TextBox[]
                    {
                        textboxAdditionAns,
                        textboxSubtractionAns,
                        textboxDivisionAns
                    }) { if (textboxes.ReadOnly != true) { textboxes.Select(); } }
                }
                else
                {
                    pictureBoxMultiplication.Visible = true;
                    pictureBoxMultiplication.Image = Properties.Resources.Wrong;
                    textboxMultiplicationAns.BackColor = Color.FromArgb(255, 247, 0);
                    wrongAnswers++;
                    grade = grade - 5;
                }
            }
            //Dieresi
            result = Convert.ToInt32(new DataTable().Compute(division, null));
            if (textboxDivisionAns.Text != "")
            {
                if (Int32.Parse(textboxDivisionAns.Text) == result)
                {
                    pictureBoxDivision.Visible = true;
                    pictureBoxDivision.Image = Properties.Resources.Correct;
                    textboxDivisionAns.ReadOnly = true;
                    textboxDivisionAns.BackColor = Color.FromArgb(28, 161, 0);
                    foreach (var textboxes in new TextBox[]
                    {
                        textboxMultiplicationAns,
                        textboxSubtractionAns,
                        textboxAdditionAns
                    }) { if (textboxes.ReadOnly != true) { textboxes.Select(); } }
                }
                else
                {
                    pictureBoxDivision.Visible = true;
                    pictureBoxDivision.Image = Properties.Resources.Wrong;
                    textboxDivisionAns.BackColor = Color.FromArgb(255, 247, 0);
                    wrongAnswers++;
                    grade = grade - 5;
                }
            }
            stopGame();
        }

        private void textboxDivisionAns_TextChanged(object sender, EventArgs e)
        {
            pictureBoxDivision.Visible = false;
            textboxDivisionAns.BackColor = Color.WhiteSmoke;
        }

        private void textboxMultiplicationAns_TextChanged(object sender, EventArgs e)
        {
            pictureBoxMultiplication.Visible = false;
            textboxMultiplicationAns.BackColor = Color.WhiteSmoke;
        }

        private void textboxSubtractionAns_TextChanged(object sender, EventArgs e)
        {
            pictureBoxSubtraction.Visible = false;
            textboxSubtractionAns.BackColor = Color.WhiteSmoke;
        }

        private void textboxAdditionAns_TextChanged(object sender, EventArgs e)
        {
            pictureBoxAddition.Visible = false;
            textboxAdditionAns.BackColor = Color.WhiteSmoke;
        }
    }
} 
 
