namespace Proekt
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startGame = new System.Windows.Forms.Button();
            this.comboLabel = new System.Windows.Forms.Label();
            this.countDownLabel = new System.Windows.Forms.Label();
            this.timerCountDown = new System.Windows.Forms.Timer(this.components);
            this.timerPlay = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.livesLabel = new System.Windows.Forms.Label();
            this.restartBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerSpeedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.inGameQ1 = new System.Windows.Forms.PictureBox();
            this.inGameQ2 = new System.Windows.Forms.PictureBox();
            this.questsLable = new System.Windows.Forms.Label();
            this.q1 = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inGameQ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inGameQ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startGame
            // 
            this.startGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startGame.Location = new System.Drawing.Point(230, 146);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(327, 113);
            this.startGame.TabIndex = 0;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // comboLabel
            // 
            this.comboLabel.AutoSize = true;
            this.comboLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboLabel.ForeColor = System.Drawing.Color.Red;
            this.comboLabel.Location = new System.Drawing.Point(12, 9);
            this.comboLabel.Name = "comboLabel";
            this.comboLabel.Size = new System.Drawing.Size(133, 25);
            this.comboLabel.TabIndex = 2;
            this.comboLabel.Text = "comboCount";
            this.comboLabel.Visible = false;
            // 
            // countDownLabel
            // 
            this.countDownLabel.AutoSize = true;
            this.countDownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countDownLabel.ForeColor = System.Drawing.Color.Red;
            this.countDownLabel.Location = new System.Drawing.Point(359, 200);
            this.countDownLabel.Name = "countDownLabel";
            this.countDownLabel.Size = new System.Drawing.Size(51, 24);
            this.countDownLabel.TabIndex = 3;
            this.countDownLabel.Text = "timer";
            this.countDownLabel.Visible = false;
            // 
            // timerCountDown
            // 
            this.timerCountDown.Interval = 1000;
            this.timerCountDown.Tick += new System.EventHandler(this.timerCountDown_Tick);
            // 
            // timerPlay
            // 
            this.timerPlay.Interval = 1000;
            this.timerPlay.Tick += new System.EventHandler(this.timerPlay_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.BackColor = System.Drawing.Color.Red;
            this.gameOverLabel.Enabled = false;
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.Location = new System.Drawing.Point(235, 146);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(184, 42);
            this.gameOverLabel.TabIndex = 4;
            this.gameOverLabel.Text = "gameover";
            this.gameOverLabel.Visible = false;
            // 
            // livesLabel
            // 
            this.livesLabel.AutoSize = true;
            this.livesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livesLabel.ForeColor = System.Drawing.Color.Red;
            this.livesLabel.Location = new System.Drawing.Point(12, 34);
            this.livesLabel.Name = "livesLabel";
            this.livesLabel.Size = new System.Drawing.Size(97, 25);
            this.livesLabel.TabIndex = 5;
            this.livesLabel.Text = "lifeCount";
            this.livesLabel.Visible = false;
            // 
            // restartBtn
            // 
            this.restartBtn.Enabled = false;
            this.restartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.Location = new System.Drawing.Point(230, 288);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.Size = new System.Drawing.Size(327, 76);
            this.restartBtn.TabIndex = 6;
            this.restartBtn.Text = "Restart Game";
            this.restartBtn.UseVisualStyleBackColor = true;
            this.restartBtn.Visible = false;
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerSpeedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // timerSpeedLabel
            // 
            this.timerSpeedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerSpeedLabel.ForeColor = System.Drawing.Color.Red;
            this.timerSpeedLabel.Name = "timerSpeedLabel";
            this.timerSpeedLabel.Size = new System.Drawing.Size(151, 20);
            this.timerSpeedLabel.Text = "toolStripStatusLabel1";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkCyan;
            this.titleLabel.Location = new System.Drawing.Point(117, 70);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(563, 73);
            this.titleLabel.TabIndex = 8;
            this.titleLabel.Text = "Precision Practice";
            // 
            // inGameQ1
            // 
            this.inGameQ1.Image = ((System.Drawing.Image)(resources.GetObject("inGameQ1.Image")));
            this.inGameQ1.InitialImage = ((System.Drawing.Image)(resources.GetObject("inGameQ1.InitialImage")));
            this.inGameQ1.Location = new System.Drawing.Point(738, 9);
            this.inGameQ1.Name = "inGameQ1";
            this.inGameQ1.Size = new System.Drawing.Size(22, 25);
            this.inGameQ1.TabIndex = 10;
            this.inGameQ1.TabStop = false;
            this.inGameQ1.Visible = false;
            // 
            // inGameQ2
            // 
            this.inGameQ2.Image = ((System.Drawing.Image)(resources.GetObject("inGameQ2.Image")));
            this.inGameQ2.InitialImage = ((System.Drawing.Image)(resources.GetObject("inGameQ2.InitialImage")));
            this.inGameQ2.Location = new System.Drawing.Point(766, 9);
            this.inGameQ2.Name = "inGameQ2";
            this.inGameQ2.Size = new System.Drawing.Size(22, 25);
            this.inGameQ2.TabIndex = 11;
            this.inGameQ2.TabStop = false;
            this.inGameQ2.Visible = false;
            // 
            // questsLable
            // 
            this.questsLable.AutoSize = true;
            this.questsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questsLable.ForeColor = System.Drawing.Color.DarkCyan;
            this.questsLable.Location = new System.Drawing.Point(13, 350);
            this.questsLable.Name = "questsLable";
            this.questsLable.Size = new System.Drawing.Size(66, 20);
            this.questsLable.TabIndex = 12;
            this.questsLable.Text = "Quests";
            // 
            // q1
            // 
            this.q1.AutoSize = true;
            this.q1.BackColor = System.Drawing.Color.DarkGray;
            this.q1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.q1.Location = new System.Drawing.Point(12, 383);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(51, 20);
            this.q1.TabIndex = 13;
            this.q1.Text = "label1";
            // 
            // q2
            // 
            this.q2.AutoSize = true;
            this.q2.BackColor = System.Drawing.Color.DarkGray;
            this.q2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.q2.Location = new System.Drawing.Point(13, 411);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(51, 20);
            this.q2.TabIndex = 14;
            this.q2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(738, 383);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.q2);
            this.Controls.Add(this.q1);
            this.Controls.Add(this.questsLable);
            this.Controls.Add(this.inGameQ2);
            this.Controls.Add(this.inGameQ1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.livesLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.countDownLabel);
            this.Controls.Add(this.comboLabel);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Precision Practice";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inGameQ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inGameQ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label comboLabel;
        private System.Windows.Forms.Label countDownLabel;
        private System.Windows.Forms.Timer timerCountDown;
        private System.Windows.Forms.Timer timerPlay;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label livesLabel;
        private System.Windows.Forms.Button restartBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timerSpeedLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox inGameQ1;
        private System.Windows.Forms.PictureBox inGameQ2;
        private System.Windows.Forms.Label questsLable;
        private System.Windows.Forms.Label q1;
        private System.Windows.Forms.Label q2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

