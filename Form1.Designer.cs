namespace Rock_Paper_Scissors
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
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtCountDown = new System.Windows.Forms.Label();
            this.TimerLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(58, 230);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(144, 40);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Rock";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(58, 321);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(144, 40);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.Text = "Paper";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(58, 410);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(144, 40);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.Text = "Scissors";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPlayer.Image = global::Rock_Paper_Scissors.Properties.Resources.qq;
            this.picPlayer.Location = new System.Drawing.Point(442, 230);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(389, 361);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 3;
            this.picPlayer.TabStop = false;
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.Location = new System.Drawing.Point(584, 151);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(179, 32);
            this.txtPlayer.TabIndex = 5;
            this.txtPlayer.Text = "Player Move:";
            // 
            // txtCPU
            // 
            this.txtCPU.AutoSize = true;
            this.txtCPU.Location = new System.Drawing.Point(1206, 161);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(157, 32);
            this.txtCPU.TabIndex = 6;
            this.txtCPU.Text = "CPU Move:";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(863, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(200, 30);
            this.txtScore.TabIndex = 7;
            this.txtScore.Text = "Score: 0";
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(863, 57);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(200, 30);
            this.txtRound.TabIndex = 8;
            this.txtRound.Text = "Round: 1";
            // 
            // picCPU
            // 
            this.picCPU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCPU.Image = global::Rock_Paper_Scissors.Properties.Resources.qq;
            this.picCPU.Location = new System.Drawing.Point(1085, 221);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(389, 361);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 10;
            this.picCPU.TabStop = false;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(58, 498);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(144, 40);
            this.BtnReset.TabIndex = 11;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtCountDown
            // 
            this.txtCountDown.AutoSize = true;
            this.txtCountDown.Location = new System.Drawing.Point(979, 282);
            this.txtCountDown.Name = "txtCountDown";
            this.txtCountDown.Size = new System.Drawing.Size(30, 32);
            this.txtCountDown.TabIndex = 12;
            this.txtCountDown.Text = "5";
            this.txtCountDown.Click += new System.EventHandler(this.label1_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Location = new System.Drawing.Point(879, 282);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(94, 32);
            this.TimerLabel.TabIndex = 13;
            this.TimerLabel.Text = "Timer:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1614, 837);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.txtCountDown);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.btnRock);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtRound);
            this.Name = "Form1";
            this.Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtCPU;
        private System.Windows.Forms.Label txtScore;
       // private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Label txtRound;
   
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Timer timer;
       // private System.Windows.Forms.Timer countDownTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtCountDown;
        private System.Windows.Forms.Label TimerLabel;
    }
}

