using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace ChatApp
{
	public partial class Form1 : Form
	{
		private TcpClient client;
		private TcpListener listener;
		private StreamReader STR;
		private StreamWriter STW;
		private string receive;
		private string TextToSend;
		private bool isServer = false;

		public Form1()
		{
			InitializeComponent();

			IPAddress[] localIP = Dns.GetHostAddresses(Dns.GetHostName());
			foreach (IPAddress address in localIP)
			{
				if (address.AddressFamily == AddressFamily.InterNetwork)
				{
					txtBoxIP.Text = address.ToString();
				}
			}
		}

		private async void btnStart_Click(object sender, EventArgs e)
		{
			try
			{
				int port = int.Parse(txtBoxPort.Text);
				listener = new TcpListener(IPAddress.Any, port);
				listener.Start();
				txtBoxChat.AppendText("Server started. Waiting for connection...\n");

				client = await listener.AcceptTcpClientAsync();
				isServer = true;
				txtBoxChat.AppendText("Client connected.\n");

				STR = new StreamReader(client.GetStream());
				STW = new StreamWriter(client.GetStream()) { AutoFlush = true };

				backgroundWorker1.RunWorkerAsync();
				backgroundWorker2.WorkerSupportsCancellation = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Server error: " + ex.Message);
			}
		}

		private void btnConnect_Click(object sender, EventArgs e)
		{
			try
			{
				client = new TcpClient();
				IPEndPoint IpEnd = new IPEndPoint(IPAddress.Parse(txtBoxIPC.Text), int.Parse(txtBoxPortC.Text));
				client.Connect(IpEnd);

				isServer = false;
				txtBoxChat.AppendText("Connected to server.\n");

				STR = new StreamReader(client.GetStream());
				STW = new StreamWriter(client.GetStream()) { AutoFlush = true };

				backgroundWorker1.RunWorkerAsync();
				backgroundWorker2.WorkerSupportsCancellation = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Client error: " + ex.Message);
			}
		}

		// PRIMAJ PORUKE
		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{
			while (client.Connected)
			{
				try
				{
					receive = STR.ReadLine();
					if (receive == null) break;

					this.txtBoxChat.Invoke(new MethodInvoker(delegate
					{
						txtBoxChat.AppendText("You: " + receive + "\n");
					}));
				}
				catch
				{
					break;
				}
			}
		}

		private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
		{
			if (client.Connected)
			{
				try
				{
					STW.WriteLine(TextToSend);
					this.txtBoxChat.Invoke(new MethodInvoker(delegate
					{
						txtBoxChat.AppendText("Me: " + TextToSend + "\n");
					}));
				}
				catch
				{
					MessageBox.Show("Sending failed.");
				}
			}
			else
			{
				MessageBox.Show("Not connected.");
			}

			backgroundWorker2.CancelAsync();
		}

		
		private void btnSend_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtBoxMessage.Text))
			{
				TextToSend = txtBoxMessage.Text;
				if (!backgroundWorker2.IsBusy)
					backgroundWorker2.RunWorkerAsync();

				txtBoxMessage.Text = "";
			}
		}
	}
}
