using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs
{
    public partial class level3 : Form
    {
        int score;
        int score1;
        public level3(int _score)
        {
            InitializeComponent();
            score = _score;
            score1 = _score;
        }
        bool goLeft, goRight, jump, isGameOver;
        int jumpSpeed;
        int force;

        int playerSpeed = 7;
        int HP = 3;
        int horizontalSpeed = 5;
        int crystals = 0;

        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;
        int enemyThreeSpeed = 5;
        int enemyFourSpeed = 3;
        int deadSpeed = 2;



        private void MainGameTimerEvent(object sender, EventArgs e)
        {

            ritual.Text = "Collect crystals";
            txtHP.Text = "HP: " + HP;
            txtScore.Text = "SCORE: " + score;
            player.Top += jumpSpeed;

            if (goLeft == true)
            {
                player.Left -= playerSpeed;
                player.Image = Properties.Resources.CONQleft;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
                player.Image = Properties.Resources.CONQright;
            }

            if (jump == true && force < 0)
            {
                jump = false;
            }
            if (jump == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;


                            if ((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }

                        }
                        x.BringToFront();

                    }

                    if ((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            score++;

                        }
                    }

                    if ((string)x.Tag == "hp")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            HP++;

                        }
                    }

                    if ((string)x.Tag == "enemy")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {

                            HP = HP - 1;
                            player.Left = 45;
                            player.Top = 485;
                            if (HP == 0)
                            {
                                txtHP.Text = "Press ENTER to restart";

                                gameTimer.Stop();
                                isGameOver = true;


                            }


                        }
                    }


                    if((string)x.Tag == "crystal")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible == true)
                        {
                            x.Visible = false;
                            crystals++;
                            score += 3;
                        

                        }
                    }


                        
                }
            }


            ////MAYAS

            en_1.Left -= enemyOneSpeed;

            if (en_1.Left < pictureBox10.Left || en_1.Left + en_1.Width > pictureBox10.Left + pictureBox10.Width)
            {
                enemyOneSpeed = -enemyOneSpeed;
                if (enemyOneSpeed > 0)
                {
                    en_1.Image = Properties.Resources.maya1;
                }
                else
                {
                    en_1.Image = Properties.Resources.maya2;
                }
            }
            
            en_2.Left -= enemyTwoSpeed;

            if (en_2.Left < pictureBox15.Left || en_2.Left + en_2.Width > pictureBox15.Left + pictureBox15.Width)
            {
                enemyTwoSpeed = -enemyTwoSpeed;
                if (enemyTwoSpeed > 0)
                {
                    en_2.Image = Properties.Resources.maya1;
                }
                else
                {
                    en_2.Image = Properties.Resources.maya2;
                }
            }

            en_3.Left -= enemyThreeSpeed;

            if (en_3.Left < pictureBox4.Left || en_3.Left + en_3.Width > pictureBox4.Left + pictureBox4.Width)
            {
                enemyThreeSpeed = -enemyThreeSpeed;
                if (enemyThreeSpeed > 0)
                {
                    en_3.Image = Properties.Resources.maya1;
                }
                else
                {
                    en_3.Image = Properties.Resources.maya2;
                }
            }

            en_4.Left -= enemyFourSpeed;

            if (en_4.Left < pictureBox13.Left || en_4.Left + en_4.Width > pictureBox13.Left + pictureBox13.Width)
            {
                enemyFourSpeed = -enemyFourSpeed;
                if (enemyThreeSpeed > 0)
                {
                    en_4.Image = Properties.Resources.maya1;
                }
                else
                {
                    en_4.Image = Properties.Resources.maya2;
                }
            }
            

            //DEADMANs
           
            dead.Left -= enemyOneSpeed;
            if (dead.Left > player.Left)
            {
                dead.Left -= deadSpeed;
                dead.Image = Properties.Resources.deadleft;
            }
            if (dead.Left < player.Left)
            {
                dead.Left += deadSpeed;
                dead.Image = Properties.Resources.deadright;
            }
            if (dead.Top > player.Top)
            {
                dead.Top -= deadSpeed;
            }
            if (dead.Top < player.Top)
            {
                dead.Top += deadSpeed;
            }

            dead1.Left -= enemyOneSpeed;
            if (dead1.Left > player.Left)
            {
                dead1.Left -= deadSpeed;
                dead1.Image = Properties.Resources.deadleft;
            }
            if (dead1.Left < player.Left)
            {
                dead1.Left += deadSpeed;
                dead1.Image = Properties.Resources.deadright;
            }
            if (dead1.Top > player.Top)
            {
                dead1.Top -= deadSpeed;
            }
            if (dead1.Top < player.Top)
            {
                dead1.Top += deadSpeed;
            }
            

            if (player.Top + player.Height > this.ClientSize.Height + 50)
            {
                HP = HP - 1;
                player.Left = 45;
                player.Top = 485;
                if (HP == 0)
                {
                    txtHP.Text = "Press ENTER to restart HP";
                    gameTimer.Stop();
                    isGameOver = true;


                }
            }

            ///////////////////////////////////////
            Altar.Visible = false;
            if(crystals == 6)
            {
                Altar.Visible = true;
                ritual.Text = "Activate the Ritual";
            }

            

            if(player.Bounds.IntersectsWith(Altar.Bounds) && Altar.Visible == true)
            {
                
                Metlan.Image = Image.FromFile("C:/Users/stast/Desktop/programming/C#/kursovik/program/assets/MetlanAttack.png");
                gameTimer.Stop();
                isGameOver = true;
                ritual.Text = "Ritual succeeded. YOU WON!!!";
                Record rec = new Record(score);
                rec.Show();
                //quit.Visible = true;
                //Application.Exit();
                //txtScore.Text = "SCORE: " + crystal;
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Space && jump == false)
            {
                jump = true;
            }
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameTimer.Stop();
            isGameOver = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (jump == true)
            {
                jump = false;
            }

            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }

            if (e.KeyCode == Keys.R)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.P)
            {
                gameTimer.Stop();
            }
            if (e.KeyCode == Keys.S)
            {
                gameTimer.Start();
            }
            if (e.KeyCode == Keys.Q)
            {

                this.Hide();
                gameTimer.Stop();
                Record rec = new Record(score);
                rec.Show();

            }

        }
        private void RestartGame()
        {
            jump = false;
            goLeft = false;
            goRight = false;
            isGameOver = false;
            score = score1;
            HP = 3;
            crystals = 0;
            Metlan.Image = Image.FromFile("C:/Users/stast/Desktop/programming/C#/kursovik/program/assets/Metlan.png");

            ritual.Text = "Collect crystals";
            txtScore.Text = "SCORE: " + score;
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }
            //quit.Visible = false;
            player.Left = 88;
            player.Top = 496;

            

            en_1.Left = 63;
            en_2.Left = 726;
            en_3.Left = 695;
            en_4.Left = 63;


            
            dead.Left = 726;
            dead.Top = 186;

            dead1.Left = 21;
            dead1.Top = 186;



            gameTimer.Start();

        }


        private void onFormClosed(object sender, FormClosedEventArgs e)
        {
            
                Application.Exit();
            
        }

    }
}
