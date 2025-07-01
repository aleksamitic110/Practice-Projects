namespace ChatApp
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
			this.label1 = new System.Windows.Forms.Label();
			this.lbIp = new System.Windows.Forms.Label();
			this.txtBoxIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtBoxPort = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtBoxPortC = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtBoxIPC = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnConnect = new System.Windows.Forms.Button();
			this.txtBoxChat = new System.Windows.Forms.TextBox();
			this.txtBoxMessage = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server";
			// 
			// lbIp
			// 
			this.lbIp.AutoSize = true;
			this.lbIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIp.Location = new System.Drawing.Point(18, 61);
			this.lbIp.Name = "lbIp";
			this.lbIp.Size = new System.Drawing.Size(32, 20);
			this.lbIp.TabIndex = 1;
			this.lbIp.Text = "IP: ";
			// 
			// txtBoxIP
			// 
			this.txtBoxIP.Location = new System.Drawing.Point(48, 60);
			this.txtBoxIP.Name = "txtBoxIP";
			this.txtBoxIP.Size = new System.Drawing.Size(148, 20);
			this.txtBoxIP.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(308, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "PORT:";
			// 
			// txtBoxPort
			// 
			this.txtBoxPort.Location = new System.Drawing.Point(370, 61);
			this.txtBoxPort.Name = "txtBoxPort";
			this.txtBoxPort.Size = new System.Drawing.Size(158, 20);
			this.txtBoxPort.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 202);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "Client";
			// 
			// txtBoxPortC
			// 
			this.txtBoxPortC.Location = new System.Drawing.Point(370, 251);
			this.txtBoxPortC.Name = "txtBoxPortC";
			this.txtBoxPortC.Size = new System.Drawing.Size(158, 20);
			this.txtBoxPortC.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(308, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "PORT:";
			// 
			// txtBoxIPC
			// 
			this.txtBoxIPC.Location = new System.Drawing.Point(48, 250);
			this.txtBoxIPC.Name = "txtBoxIPC";
			this.txtBoxIPC.Size = new System.Drawing.Size(148, 20);
			this.txtBoxIPC.TabIndex = 7;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(18, 251);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "IP: ";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(581, 44);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(122, 51);
			this.btnStart.TabIndex = 10;
			this.btnStart.Text = "START";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnConnect
			// 
			this.btnConnect.Location = new System.Drawing.Point(581, 234);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(122, 51);
			this.btnConnect.TabIndex = 11;
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
			// 
			// txtBoxChat
			// 
			this.txtBoxChat.Location = new System.Drawing.Point(22, 307);
			this.txtBoxChat.Multiline = true;
			this.txtBoxChat.Name = "txtBoxChat";
			this.txtBoxChat.Size = new System.Drawing.Size(681, 235);
			this.txtBoxChat.TabIndex = 12;
			// 
			// txtBoxMessage
			// 
			this.txtBoxMessage.Location = new System.Drawing.Point(22, 548);
			this.txtBoxMessage.Multiline = true;
			this.txtBoxMessage.Name = "txtBoxMessage";
			this.txtBoxMessage.Size = new System.Drawing.Size(506, 89);
			this.txtBoxMessage.TabIndex = 13;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(534, 548);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(169, 89);
			this.btnSend.TabIndex = 14;
			this.btnSend.Text = "SEND";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// backgroundWorker2
			// 
			this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(763, 764);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.txtBoxMessage);
			this.Controls.Add(this.txtBoxChat);
			this.Controls.Add(this.btnConnect);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtBoxPortC);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtBoxIPC);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtBoxPort);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtBoxIP);
			this.Controls.Add(this.lbIp);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbIp;
		private System.Windows.Forms.TextBox txtBoxIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtBoxPort;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtBoxPortC;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtBoxIPC;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnConnect;
		private System.Windows.Forms.TextBox txtBoxChat;
		private System.Windows.Forms.TextBox txtBoxMessage;
		private System.Windows.Forms.Button btnSend;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
	}
}

