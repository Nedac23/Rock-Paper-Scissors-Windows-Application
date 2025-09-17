using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Rock_Paper_Scissors
{
    public partial class Form1 : Form
    {


        int rounds = 3;
        int timerPerRound = 100;

        bool gameover = false;

        string[] CPUchoiceList = { "rock", "paper", "scissor", "paper", "scissor", "rock" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUchoice;

        string playerChoice;

        int playerwins;
        int AIwins;

        private void SaveResult(string winner, int playerScore, int cpuScore)
        {
            string dbPath = @"SQLfilepathname";

            using (var conn = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                conn.Open();

                // Ensure the table exists
                string createTableQuery = @"
            CREATE TABLE IF NOT EXISTS GameResults (
                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                Winner TEXT NOT NULL,
                PlayerScore INT,
                CPUScore INT,
                DatePlayed DATETIME
            );";
                using (var createCmd = new SQLiteCommand(createTableQuery, conn))
                {
                    createCmd.ExecuteNonQuery();
                }

                // Insert the new result
                string query = "INSERT INTO GameResults (Winner, PlayerScore, CPUScore, DatePlayed) VALUES (@Winner, @PlayerScore, @CPUScore, @DatePlayed)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Winner", winner);
                    cmd.Parameters.AddWithValue("@PlayerScore", playerScore);
                    cmd.Parameters.AddWithValue("@CPUScore", cpuScore);
                    cmd.Parameters.AddWithValue("@DatePlayed", DateTime.Now);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
            string dbPath = @"SQL filepath name";
            MessageBox.Show("Database path: " + dbPath);
            timer1.Enabled = true;
            playerChoice = "none";
            txtCountDown.Text = "100";
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissors;
            playerChoice = "scissor";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerPerRound -= 1;

            txtCountDown.Text = timerPerRound.ToString();
            txtRound.Text = "Rounds: " + rounds;

            if (timerPerRound < 1)
            {
                timer1.Enabled = false;
                timerPerRound = 100;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUchoice = CPUchoiceList[randomNumber];

                switch (CPUchoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.rock;
                        break;
                    case "paper":
                        picCPU.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        picCPU.Image = Properties.Resources.scissors;
                        break;
                }


                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerwins > AIwins)
                    {
                        MessageBox.Show("Player Wins This Game");
                        SaveResult("Player", playerwins, AIwins);
                    }
                    else
                    {
                        MessageBox.Show("CPU Wins This Game");
                        SaveResult("CPU", playerwins, AIwins);
                    }

                    gameover = true;
                }


            }
        }


        private void checkGame()
        {

            // AI and player win rules

            if (playerChoice == "rock" && CPUchoice == "paper")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "scissor" && CPUchoice == "rock")
            {
                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Rock Breaks Scissors");
            }
            else if (playerChoice == "paper" && CPUchoice == "scissor")
            {

                AIwins += 1;

                rounds -= 1;

                MessageBox.Show("CPU Wins, Scissor cuts paper");

            }
            else if (playerChoice == "rock" && CPUchoice == "scissor")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Rock Breaks Scissors");

            }
            else if (playerChoice == "paper" && CPUchoice == "rock")
            {

                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Paper Covers Rocks");

            }
            else if (playerChoice == "scissor" && CPUchoice == "paper")
            {
                playerwins += 1;

                rounds -= 1;

                MessageBox.Show("Player Wins, Scissor cuts paper");

            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("Make your Choice");
            }
            else
            {
                MessageBox.Show("Draw");

            }

            startNextRound();
        }

        public void startNextRound()
        {

            if (gameover)
            {



                return;
            }

            txtScore.Text = "Player: " + playerwins + " - " + "CPU: " + AIwins;

            playerChoice = "none";

            timer1.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void BtnReset_Click(object sender, EventArgs e)
        {
            playerwins = 0;
            AIwins = 0;
            rounds = 3;
            txtScore.Text = "Player: " + playerwins + " - " + "CPU: " + AIwins;

            playerChoice = "none";
            txtCountDown.Text = "100";

            timer1.Enabled = true;

            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;

            gameover = false;
        }
    }
}
