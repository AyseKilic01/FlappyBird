using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class FrmMain : Form
    {
        int pipeSpeed = 8;
        int score = 0;
        int gravity = 10;
        
        public FrmMain()
        {
            InitializeComponent();
        }
        #region Events
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            flappy.Top += gravity;
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            lblScore.Text = "Score : " + score.ToString();
            lblOver.Visible = false;

            if(pipeBottom.Left < -150)
            {
                pipeBottom.Left = 400;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 500;
                score++;
            }
            if(flappy.Bounds.IntersectsWith(pipeBottom.Bounds) || flappy.Bounds.IntersectsWith(pipeTop.Bounds) 
                || flappy.Bounds.IntersectsWith(ground.Bounds) || flappy.Top < -25)
            {
                GameOver();
            }
            if(score > 5)
            {
                pipeSpeed += 15;
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        #endregion
        #region Methods
        private void GameOver()
        {
            gameTimer.Stop();
            lblOver.Visible = true;
            lblOver.Text = " Game Over !!!";
        }
        #endregion
    }
}
