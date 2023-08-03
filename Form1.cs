using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bird_Shooter
{
    sealed public partial class MainFrame : Form
    {

        // Variables
        private int game_frame_Height = 1000;
        private int game_frame_Width = 1200;
        private int bullets_left = 10;
        private int score_var = 0;
        private int hits_var = 0;
        private int missed_var = 0;
        private bool game_running = true;

        // Get biggest score
        private int get_biggest_score_f()
        {
            if (!File.Exists("BiggestScore.txt"))
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(File.ReadAllText("BiggestScore.txt"));
            }
             
        }

        public MainFrame()
        {
            InitializeComponent();
        }


        // Game start
        private void MainFrame_Load(object sender, EventArgs e)
        {
            // Focus game frame
            this.CenterToScreen();
            this.Focus();
            game_running = true;
            timer1.Start();

            // Set stats
            Score.Text = "0";
            Bullets.Text = bullets_left.ToString();
            Hits.Text = "0";
            Missed.Text = "0";
            MVP.Text = get_biggest_score_f().ToString();

            // Hide game over screen
            GO_screen.Visible = false;
        }

        // Exit button
        private void label3_Click(object sender, EventArgs e)
        {
            if(!File.Exists("BiggestScore.txt"))
            {
                File.WriteAllText("BiggestScore.txt", score_var.ToString());
            }
            else
            {
                int current_biggest_score = Convert.ToInt32(File.ReadAllText("BiggestScore.txt"));
                if(score_var  > current_biggest_score)
                {
                    File.Delete("BiggestScore.txt");
                    File.WriteAllText("BiggestScore.txt", score_var.ToString());
                }

            MVP.Text = File.ReadAllText("BiggestScore.txt");
            }
            this.Close();
        }

        // Restart button
        private void label4_Click(object sender, EventArgs e)
        {
            // Reset variables
            bullets_left = 10;
            hits_var = 0;
            missed_var = 0;

            // Reset HUD
            Bullets.Text = bullets_left.ToString();
            Score.Text = score_var.ToString();
            Hits.Text = hits_var.ToString();
            Missed.Text = missed_var.ToString();

            // Restart game
            game_running = true;
            GO_screen.Visible = false;
            timer1.Start();

            if (!File.Exists("BiggestScore.txt"))
            {
                File.WriteAllText("BiggestScore.txt", score_var.ToString());
            }
            else
            {
                int current_biggest_score = Convert.ToInt32(File.ReadAllText("BiggestScore.txt"));
                if (score_var > current_biggest_score)
                {
                    File.Delete("BiggestScore.txt");
                    File.WriteAllText("BiggestScore.txt", score_var.ToString());
                }

                MVP.Text = File.ReadAllText("BiggestScore.txt");
            }

            // Default score
            score_var = 0;
            Score.Text = "0";
        }

        // Move player every 0.6 seconds to a random position
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(game_running == false)
            {
                timer1.Stop();
            }

            if(bullets_left == 0) {
                GO_screen.Visible = true;
                game_running = false;
                if (!File.Exists("BiggestScore.txt"))
                {
                    File.WriteAllText("BiggestScore.txt", score_var.ToString());
                }
                else
                {
                    int current_biggest_score = Convert.ToInt32(File.ReadAllText("BiggestScore.txt"));
                    if (score_var > current_biggest_score)
                    {
                        File.Delete("BiggestScore.txt");
                        File.WriteAllText("BiggestScore.txt", score_var.ToString());
                    }

                    MVP.Text = File.ReadAllText("BiggestScore.txt");
                }
                return;
            }

            Random my_random_number = new Random();
            Player.Location = new Point(my_random_number.Next(Player.Width/3, game_frame_Width - Player.Width),
                my_random_number.Next(label6.Location.Y + label6.Height/2, (game_frame_Height * 3) / 4));
        }

        // Click on player
        private void Player_Click(object sender, EventArgs e)
        {
            // Check if we have bullets left
            if (bullets_left == 0)
            {
                game_over();
                return;
            }

            // Increase variables
            score_var = score_var + 10;
            hits_var++;
            bullets_left--;
            shot_Sound();

            // Display them
            Score.Text = score_var.ToString();
            Hits.Text = hits_var.ToString();
            Bullets.Text = bullets_left.ToString();
        }

        // Click outside the target
        private void MainFrame_MouseClick(object sender, MouseEventArgs e)
        {
            // Check if we still have bullets
            if (bullets_left == 0)
            {
                game_over();
                return;
            }

            // Update variables
            bullets_left--;
            missed_var++;
            shot_Sound();


            // Update HUD
            Bullets.Text = bullets_left.ToString();
            Missed.Text = missed_var.ToString();
        }

        // Game over screen
        private void game_over()
        {
            GO_screen.Visible = true;
            game_running = false;
        }

        // Void shot sound
        void shot_Sound()
        {
            string path = System.Reflection.Assembly.GetExecutingAssembly().Location;
            path = Path.GetDirectoryName(path);
            path = Path.Combine(path, "../../Sounds/bullet_shot.wav");
            System.Media.SoundPlayer my_bullet_shot = new System.Media.SoundPlayer(path);
            my_bullet_shot.Play();
        }
    }
}
