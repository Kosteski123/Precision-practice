using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proekt.Properties;


namespace Proekt
{
    public partial class Form1 : Form
    {
        public Scene scene;
        public int decrease;
        public Random r;
        public int flagStart;
        public string win = "        You Won\nHighest Combo: ";
        public string lose = "        You Lose\nHighest Combo: ";
        public int flag = 0;                //to prevent from clicking when game ends 
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            scene = new Scene();
            decrease = 2000;
            flagStart = 4;
            this.BackColor = Color.DarkGray;
            DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            titleLabel.Visible = false;
            titleLabel.Enabled = false;
            startGame.Visible = false;      //button
            startGame.Enabled = false;
            ruleLabel.Visible = false;
            ruleLabel.Enabled = false;
            timerCountDown.Start();
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            //TODO
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
                //TODO
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //TODO
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
