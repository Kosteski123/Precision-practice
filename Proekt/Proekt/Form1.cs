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
            countDownLabel.Visible = true;
            flagStart--;
            countDownLabel.Text = flagStart.ToString();
            if (flagStart == 0)
            {
                countDownLabel.Text = "Get Ready!!!";
            }
            else if (flagStart == -1)
            {
                countDownLabel.Visible = false;
                timerCountDown.Stop();
                timerPlay.Start();
            }
        }

        private void timerPlay_Tick(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            comboLabel.Visible = true;
            livesLabel.Visible = true;
            timerPlay.Interval = decrease;
            timerSpeedLabel.Text = string.Format("Timer Speed: " + decrease + "ms");
            if (decrease >= 1000)
                decrease -= 50;
            else if (decrease < 1000)
                decrease -= 20;
            timerPlay.Interval = decrease;
            int y = r.Next(2 * Circles.radius, Height - (Circles.radius * 2));      //random loc
            int x = r.Next(2 * Circles.radius, Width - (Circles.radius * 2));
            Circles c = new Circles(new Point(x, y));
            scene.addC(c);
            comboLabel.Text = string.Format("Combo: " + scene.Combo);
            if (scene.threeLives >= 0)
            {
                livesLabel.Text = string.Format("♥ x " + scene.threeLives);
            }
            else
            {
                //scene.removeAllC();
                timerPlay.Stop();
                this.BackColor = Color.DarkGray;
                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                gameOverLabel.Text = string.Format(lose + scene.flagMax);
                restartBtn.Visible = true;
                restartBtn.Enabled = true;
                scene.removeAllC();
                flag = 1;
            }
            if (timerPlay.Interval < 500)
            {
                scene.removeAllC();                             //*   treba dvapati da ja ima ovaa funkcija za da raboti
                timerPlay.Stop();
                this.BackColor = Color.DarkGray;
                gameOverLabel.Enabled = true;
                gameOverLabel.Visible = true;
                gameOverLabel.Text = string.Format(win + scene.flagMax);
                restartBtn.Visible = true;
                restartBtn.Enabled = true;
                scene.removeAllC();                              //*
                flag = 1;
            }
            scene.removeC();
            Invalidate(true);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (startGame.Visible == false && timerCountDown.Enabled == false && flag == 0)
            {
                scene.Click(e.X, e.Y);
                scene.removeC();
                timerPlay_Tick(null, null);
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
