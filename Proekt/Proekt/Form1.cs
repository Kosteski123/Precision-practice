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
        public int timer;
        public int decrease;
        public Random r;
        public int flagStart;
        public string win = "        You Won\nHighest Combo: ";
        public string lose = "        You Lose\nHighest Combo: ";
        public int flag = 0;                //to prevent from clicking when game ends 
        public int quest1;
        public int quest2;
        private Form2 howToPlayWindow = new Form2();
        public Form1()
        {
            InitializeComponent();
            r = new Random();
            scene = new Scene();
            timer = 0;
            decrease = 2000;
            flagStart = 4;
            this.BackColor = Color.DarkGray;
            DoubleBuffered = true;
            quest1 = r.Next(6);
            while (true)               //ovoj while e za da se vidi dali se izbrani razlicni quests
            {
                quest2 = r.Next(6);
                if (quest2 != quest1)
                {
                    break;
                }
            }
            this.quest(quest1, quest2);


        }
        private void quest(int quest1, int quest2)
        {
            //Ovaa funkcija e za da se setira labelata za quests pod Start game kopceto!
            switch (quest1)
            {
                case 0:
                    q1.Text = "Get a max combo of 20 circles in a row!";
                    break;
                case 1:
                    q1.Text = "Complete the game with 3 lives!";
                    break;
                case 2:
                    q1.Text = "Complete the game with 2 lives remaining!";
                    break;
                case 3:
                    q1.Text = "Get a max combo of 25 circles in a row!";
                    break;
                case 4:
                    q1.Text = "Reach a speed of 600 or less!";
                    break;
                default:
                    q1.Text = "Reach a speed of 1000 or less!";
                    break;
            }
            switch (quest2)
            {
                case 0:
                    q2.Text = "Get a max combo of 20 circles in a row!";
                    break;
                case 1:
                    q2.Text = "Complete the game with 3 lives!";
                    break;
                case 2:
                    q2.Text = "Complete the game with 2 lives remaining!";
                    break;
                case 3:
                    q2.Text = "Get a max combo of 25 circles in a row!";
                    break;
                case 4:
                    q2.Text = "Reach a speed of 600 or less!";
                    break;
                default:
                    q2.Text = "Reach a speed of 1000 or less!";
                    break;
            }
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
            // ruleLabel.Visible = false;
            // ruleLabel.Enabled = false;
            pictureBox1.Visible = false;
            questsLable.Visible = false;
            q1.Visible = false;         //remove the quest labels to reduce visual clutter
            q1.Enabled = false;
            q2.Visible = false;
            q2.Enabled = false;
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
                inGameQ1.BackColor = Color.DarkGray;
                inGameQ2.BackColor = Color.DarkGray;
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
                inGameQ1.BackColor = Color.DarkGray;
                inGameQ2.BackColor = Color.DarkGray;
                scene.removeAllC();                              //*
                flag = 1;
            }
            this.checkQuests(); //proveruva dali se postignati samite quests
            scene.removeC();
            Invalidate(true);
        }

        private void checkQuests()
        {
            //Ovaa funkcija e za da se setiraat lavelite za completed quests i da se vidi dali se
            //postignati
            switch (quest1)
            {
                case 0:
                    if (scene.Combo >= 20)
                    {
                        inGameQ1.Visible = true;
                        inGameQ1.Enabled = true;
                    }
                    break;
                case 1:
                    if (gameOverLabel.Visible == true && scene.threeLives == 3)
                    {
                        inGameQ1.Visible = true;
                        inGameQ1.Enabled = true;
                        inGameQ1.BackColor = Color.DarkGray;
                    }

                    break;
                case 2:
                    if (gameOverLabel.Visible == true && scene.threeLives == 2)
                    {
                        inGameQ1.Visible = true;
                        inGameQ1.Enabled = true;
                        inGameQ1.BackColor = Color.DarkGray;
                    }
                    break;
                case 3:
                    if (scene.Combo >= 25)
                    {
                        inGameQ1.Visible = true;
                        inGameQ1.Enabled = true;
                    }
                    break;
                case 4:
                    if (timerPlay.Interval <= 600)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                    }
                    break;
                default:
                    if (timerPlay.Interval <= 1000)
                    {
                        inGameQ1.Visible = true;
                        inGameQ1.Enabled = true;
                    }
                    break;
            }
            switch (quest2)
            {
                case 0:
                    if (scene.Combo >= 20)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                    }
                    break;
                case 1:
                    if (gameOverLabel.Visible == true && scene.threeLives == 3)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                        inGameQ2.BackColor = Color.DarkGray;
                    }

                    break;
                case 2:
                    if (gameOverLabel.Visible == true && scene.threeLives == 2)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                        inGameQ2.BackColor = Color.DarkGray;
                    }
                    break;
                case 3:
                    if (scene.Combo >= 25)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                    }
                    break;
                case 4:
                    if (timerPlay.Interval <= 600)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                    }
                    break;
                default:
                    if (timerPlay.Interval <= 1000)
                    {
                        inGameQ2.Visible = true;
                        inGameQ2.Enabled = true;
                    }
                    break;
            }

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            howToPlayWindow.ShowDialog();
        }
    }
}
