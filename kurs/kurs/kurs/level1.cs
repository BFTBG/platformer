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
    public partial class level1 : Form
    {
        bool goLeft, goRight, jump, isGameOver;
        int jumpSpeed;
        int force;
        int score = 0;
        int playerSpeed = 7;
        int HP = 3;
        int horizontalSpeed = 5;
        int VerticalSpeed = 3;


        int enemyOneSpeed = 5;
        int enemyTwoSpeed = 3;


        public level1()
        {
            InitializeComponent();

        }

        private void MainGameTimerEvent(object sender, EventArgs e)
        {
            txtScore.Text = "SCORE: " + score;
            txtHP.Text = "HP: " + HP;

            player.Top += jumpSpeed;

            if(goLeft == true)
            {
                player.Left -= playerSpeed;
                player.Image = Properties.Resources.CONQleft;
            }
            if (goRight == true)
            {
                player.Left += playerSpeed;
                player.Image = Properties.Resources.CONQright;
            }

            if(jump == true && force <0)
            {
                jump = false;
            }
            if(jump == true)
            {
                jumpSpeed = -8;
                force -= 1;
            }
            else
            {
                jumpSpeed = 10;
            }

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox)
                {
                    if((string)x.Tag=="platform")
                    {
                        if(player.Bounds.IntersectsWith(x.Bounds))
                        {
                            force = 8;
                            player.Top = x.Top - player.Height;


                            if((string)x.Name == "horizontalPlatform" && goLeft == false || (string)x.Name == "horizontalPlatform" && goRight == false)
                            {
                                player.Left -= horizontalSpeed;
                            }

                        }
                        x.BringToFront();

                    }

                    if((string)x.Tag == "coin")
                    {
                        if (player.Bounds.IntersectsWith(x.Bounds) && x.Visible ==true)
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

                            HP =HP- 1;
                            player.Left = 45;
                            player.Top = 485;
                            if(HP==0)
                            {
                                txtHP.Text = "Press ENTER to restart HP: " + HP;
                                txtScore.Text = "SCORE: " + score + Environment.NewLine + "You were killed!!! Press ENTER to restart";
                                gameTimer.Stop();
                                isGameOver = true;
                               

                            }


                        }
                    }
                }
            }

            horizontalPlatform.Left -= horizontalSpeed;

            if(horizontalPlatform.Left<0 || horizontalPlatform.Left + horizontalPlatform.Width>this.ClientSize.Width)
            {
                horizontalSpeed = -horizontalSpeed;

            }

            vericalPlatform.Top -= VerticalSpeed;

            if (vericalPlatform.Top < 245 || vericalPlatform.Top > 411 )
            {
                VerticalSpeed = -VerticalSpeed;

            }

            en_1.Left -= enemyOneSpeed;

            if(en_1.Left<pictureBox2.Left || en_1.Left+en_1.Width>pictureBox2.Left+pictureBox2.Width)
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

            if (en_2.Left < pictureBox5.Left || en_2.Left + en_2.Width > pictureBox5.Left + pictureBox5.Width)
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

            if (player.Top + player.Height >this.ClientSize.Height+50)
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

            if (player.Bounds.IntersectsWith(door.Bounds) && score >= 10)
            {
                level2 newLevel = new level2(score);
                this.Hide();
                
                gameTimer.Stop();
                newLevel.Show();


            }
            else if(!player.Bounds.IntersectsWith(door.Bounds) && score >= 10)
            {
                txtScore.Text = "SCORE: " + score + Environment.NewLine + "Door is opened";
            }
            else
            {
                txtScore.Text = "SCORE: " + score + Environment.NewLine + "Collect all coins";

            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
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

            if(e.KeyCode == Keys.Enter && isGameOver == true)
            {
                RestartGame();
            }

            if(e.KeyCode == Keys.R)
            {
                RestartGame();
            }
            if(e.KeyCode == Keys.P)
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
            score = 0;
            HP = 3;

            txtScore.Text = "SCORE: " + score;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Visible == false)
                {
                    x.Visible = true;
                }
            }

            player.Left = 45;
            player.Top = 485;


            en_1.Left = 282;
            en_2.Left = 448;

            horizontalPlatform.Left = 45;
            vericalPlatform.Top = 373;

            gameTimer.Start();

        }



        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
