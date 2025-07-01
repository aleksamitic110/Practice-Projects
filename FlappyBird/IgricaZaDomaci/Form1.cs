using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IgricaZaDomaci
{
	public partial class Form1 : Form
	{
	
		int barierSpeed = 8;
		int gravity = 15;
		int score = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void gameTimerEvent(object sender, EventArgs e)
		{
			FlappyBird.Top += gravity;
			barierBottom.Left -= barierSpeed;
			barierTop.Left -= barierSpeed;

			scoreLb.Text = score.ToString();

			if (barierBottom.Left < -150)
			{
				barierBottom.Left = 800;
				score++;
			}

			if (barierTop.Left < -180)
			{
				barierTop.Left = 950;
				score++;
			}

			if (FlappyBird.Bounds.IntersectsWith(barierBottom.Bounds) || 
				FlappyBird.Bounds.IntersectsWith(barierTop.Bounds) || 
				FlappyBird.Bounds.IntersectsWith(Grand.Bounds) ||
				FlappyBird.Top < -25)
			{
				endGame();
			}

			

			if (score > 10)
				barierSpeed = 10;
			if (score > 15)
				barierSpeed = 15;
			if (score > 25)
				barierSpeed = 20;
			if (score > 35)
				barierSpeed = 25;
			if (score > 45)
				barierSpeed = 30;


		}



		private void gameKeyIsDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space) {
				gravity = -15;
			}
		}

		private void gameKeyIsUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = 15;
			}
		}

		private void endGame() {
			gameTimer.Stop();
			scoreLb.Text += " Game Over!!!";
		}



		private void gameMosueIsDown(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				gravity = -15;
			}
		}

		private void gameMouseIsUp(object sender, MouseEventArgs e)
		{
			if (e.Button == System.Windows.Forms.MouseButtons.Left)
			{
				gravity = 15;
			}
		}

		private void restart(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 'r')
				Application.Restart();
		}
	}
}
