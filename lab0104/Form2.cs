using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab0104
{
    public partial class Form2 : Form
    {
        private bool isWinningTime = false;
        private int countWins = 0;
        
        private int seconds = 120;
        static  private Random rnd = new Random();
        private int winIndex = rnd.Next(1,26);
        public Form2()
        {
            InitializeComponent();
        }
        private void WinGame()
        {
            timer.Stop();
            Program.isGamePlayed = true;
            MessageBox.Show("Вы победили");
            Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                timerTextbox.Text = (seconds / 60).ToString() + ":" + (seconds % 60).ToString();

            }
            else 
            {
                Hide();
                Form3 form3 = new Form3();
                timer.Stop();
                form3.ShowDialog();

                Program.userPoints = countWins;
                Close();
            };
        }
        private bool iswin(int a) 
        {
            if (a ==winIndex)
            {
                return true;
            }
            return false;
        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (iswin(1)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                
                pictureBox1.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox1.Image = global::lab0104.Properties.Resources._1;

        }

        private void clearPictureBox()
        {
            isWinningTime = false;
            timerWin.Stop();
            
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            pictureBox10.Image = null;
            pictureBox11.Image = null;
            pictureBox12.Image = null;
            pictureBox13.Image = null;
            pictureBox14.Image = null;
            pictureBox15.Image = null;
            pictureBox16.Image = null;
            pictureBox17.Image = null;
            pictureBox18.Image = null;
            pictureBox19.Image = null;
            pictureBox20.Image = null;
            pictureBox21.Image = null;
            pictureBox22.Image = null;
            pictureBox23.Image = null;
            pictureBox24.Image = null;
            pictureBox25.Image = null;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (iswin(2)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox2.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox2.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (iswin(3)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox3.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox3.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (iswin(4)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox4.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox4.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (iswin(5)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox5.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox5.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (iswin(6)&&!isWinningTime)
            {
                timerWin.Start(); 
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox6.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox6.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (iswin(7)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox7.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox7.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (iswin(8)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox8.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox8.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (iswin(9)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox9.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox9.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (iswin(10)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox10.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox10.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (iswin(11)&&isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox11.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox11.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (iswin(12)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox12.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
               
            }
            else if(!isWinningTime) pictureBox12.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (iswin(13)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox13.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox13.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (iswin(14)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox14.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox14.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (iswin(15)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox15.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox15.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (iswin(16)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox16.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox16.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (iswin(17)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox17.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
               
            }
            else if(!isWinningTime) pictureBox17.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (iswin(18)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox18.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox18.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (iswin(19)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox19.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
               
            }
            else if(!isWinningTime) pictureBox19.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (iswin(20)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox20.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
              
            }
            else if(!isWinningTime) pictureBox20.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            if (iswin(21)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox21.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox21.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            if (iswin(22)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox22.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox22.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            if (iswin(23)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox23.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox23.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            if (iswin(24)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox24.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox24.Image = global::lab0104.Properties.Resources._1;
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            if (iswin(25)&&!isWinningTime)
            {
                timerWin.Start();
                countWins++;
                isWinningTime = true;
                if (countWins == 10)
                {
                    WinGame();
                }
                pictureBox25.Image = global::lab0104.Properties.Resources._2;
                winIndex = rnd.Next(1, 26);
                
            }
            else if(!isWinningTime) pictureBox25.Image = global::lab0104.Properties.Resources._1;
        }

        private void timerWin_Tick(object sender, EventArgs e)
        {
            clearPictureBox();
        }
    }
}
