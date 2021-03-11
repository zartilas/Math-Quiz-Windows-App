using FinalErgasia2.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace FinalErgasia2
{
    public partial class Calculator : Form
    {
        public static int helps = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Backspace_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length != 0)
            {
                textBoxInput.Text = textBoxInput.Text.Remove(textBoxInput.Text.Length - 1, 1);
            }     
            return;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "9";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "0";
        }

        private void button_Addition_Click(object sender, EventArgs e)
        {
            
            textBoxInput.Text = textBoxInput.Text + "+";
        }

        private void button_Subtraction_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "-";
        }

        private void button_Multiplication_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "x";
        }

        private void button_Division_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = textBoxInput.Text + "÷";
        }

        private void button_Result_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text != "" )
            {
                try
                {
                    int result = Convert.ToInt32(new DataTable().Compute(textBoxInput.Text.Replace("x","*").Replace("÷", "/"), null));
                    textBoxInput.Text = result.ToString();
                    helps++;
                    if (helps == 2)
                    {
                        MsgBox msgBox = new MsgBox();
                        msgBox.Msg();

                        this.Close();
                        Game game = new Game();
                    }
                }
                catch (SyntaxErrorException)
                {
                    labelError.Visible = true;
                }
            }
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            labelError.Visible = false;
        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Auto tha apotrepsei ton xristi na xrisimopisi space & allous xaraktires.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            //Apenergopioisi tou paste (Ctrl + V).
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
