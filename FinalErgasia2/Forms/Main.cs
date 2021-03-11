using System;
using System.Windows.Forms;

namespace FinalErgasia2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            Form Game = new Game();
            this.Hide();
            Game.ShowDialog();
            this.Close();
        }

        private void pictureBoxInfo_MouseEnter(object sender, EventArgs e)
        {
            panelInfo.Visible = true;
            labelInfo.Visible = true;
        }

        private void pictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            panelInfo.Visible = false;
            labelInfo.Visible = false;
        }
    }
}
