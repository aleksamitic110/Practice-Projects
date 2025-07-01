namespace IgricaZaDomaci
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
			this.scoreLb = new System.Windows.Forms.Label();
			this.Grand = new System.Windows.Forms.PictureBox();
			this.barierBottom = new System.Windows.Forms.PictureBox();
			this.barierTop = new System.Windows.Forms.PictureBox();
			this.FlappyBird = new System.Windows.Forms.PictureBox();
			this.gameTimer = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Grand)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barierBottom)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.barierTop)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
			this.SuspendLayout();
			// 
			// scoreLb
			// 
			this.scoreLb.AutoSize = true;
			this.scoreLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.scoreLb.Location = new System.Drawing.Point(12, 594);
			this.scoreLb.Name = "scoreLb";
			this.scoreLb.Size = new System.Drawing.Size(157, 42);
			this.scoreLb.TabIndex = 4;
			this.scoreLb.Text = "Score: 0";
			// 
			// Grand
			// 
			this.Grand.Image = global::IgricaZaDomaci.Properties.Resources.ground;
			this.Grand.Location = new System.Drawing.Point(2, 576);
			this.Grand.Name = "Grand";
			this.Grand.Size = new System.Drawing.Size(589, 60);
			this.Grand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Grand.TabIndex = 3;
			this.Grand.TabStop = false;
			// 
			// barierBottom
			// 
			this.barierBottom.Image = global::IgricaZaDomaci.Properties.Resources.pipe;
			this.barierBottom.Location = new System.Drawing.Point(366, 401);
			this.barierBottom.Name = "barierBottom";
			this.barierBottom.Size = new System.Drawing.Size(100, 185);
			this.barierBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.barierBottom.TabIndex = 2;
			this.barierBottom.TabStop = false;
			// 
			// barierTop
			// 
			this.barierTop.Image = global::IgricaZaDomaci.Properties.Resources.pipedown;
			this.barierTop.Location = new System.Drawing.Point(481, -3);
			this.barierTop.Name = "barierTop";
			this.barierTop.Size = new System.Drawing.Size(100, 191);
			this.barierTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.barierTop.TabIndex = 1;
			this.barierTop.TabStop = false;
			// 
			// FlappyBird
			// 
			this.FlappyBird.Image = global::IgricaZaDomaci.Properties.Resources.bird;
			this.FlappyBird.Location = new System.Drawing.Point(19, 73);
			this.FlappyBird.Name = "FlappyBird";
			this.FlappyBird.Size = new System.Drawing.Size(78, 59);
			this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.FlappyBird.TabIndex = 0;
			this.FlappyBird.TabStop = false;
			// 
			// gameTimer
			// 
			this.gameTimer.Enabled = true;
			this.gameTimer.Interval = 20;
			this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(267, 605);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(314, 24);
			this.label1.TabIndex = 5;
			this.label1.Text = "Space or Left click to play R to restart";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(591, 638);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.scoreLb);
			this.Controls.Add(this.FlappyBird);
			this.Controls.Add(this.Grand);
			this.Controls.Add(this.barierBottom);
			this.Controls.Add(this.barierTop);
			this.Name = "Form1";
			this.Text = "Flappy Bird";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.restart);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gameMosueIsDown);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gameMouseIsUp);
			((System.ComponentModel.ISupportInitialize)(this.Grand)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barierBottom)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.barierTop)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox FlappyBird;
		private System.Windows.Forms.PictureBox barierTop;
		private System.Windows.Forms.PictureBox barierBottom;
		private System.Windows.Forms.PictureBox Grand;
		private System.Windows.Forms.Label scoreLb;
		private System.Windows.Forms.Timer gameTimer;
		private System.Windows.Forms.Label label1;
	}
}

