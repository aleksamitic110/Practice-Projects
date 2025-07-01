using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitron
{
	public partial class Digitron : Form
	{
		public Digitron(){
			InitializeComponent();
			dig = new digitron();
			this.Rezultat.Lines = new string[2];
		}

		private void Rezultat_TextChanged(object sender, EventArgs e){

		}

		private void Dugme1_Click(object sender, EventArgs e){
			dig.trenutni += "1";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme2_Click(object sender, EventArgs e){
			dig.trenutni += "2";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme3_Click(object sender, EventArgs e){
			dig.trenutni += "3";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme4_Click(object sender, EventArgs e){
			dig.trenutni += "4";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme5_Click(object sender, EventArgs e){
			dig.trenutni += "5";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme6_Click(object sender, EventArgs e){
			dig.trenutni += "6";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme7_Click(object sender, EventArgs e){
			dig.trenutni += "7";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme8_Click(object sender, EventArgs e){
			dig.trenutni += "8";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Dugme9_Click(object sender, EventArgs e){
			dig.trenutni += "9";
			this.Rezultat.Text = dig.trenutni;
		}
		private void Dugme0_Click(object sender, EventArgs e){
			dig.trenutni += "0";
			this.Rezultat.Text = dig.trenutni;
		}

		private void Mnozenje_Click(object sender, EventArgs e){
			dig.op(dig.operacija);
			dig.operacija = '*';
			this.Rezultat.Text = dig.rezultat.ToString();
		}

		private void Deljenje_Click(object sender, EventArgs e){
			dig.op(dig.operacija);
			dig.operacija = '/';
			this.Rezultat.Text = dig.rezultat.ToString();
		}

		private void Sabiranje_Click(object sender, EventArgs e){
			dig.op(dig.operacija);
			dig.operacija = '+';
			this.Rezultat.Text = dig.rezultat.ToString();
		}

		private void Oduzimanje_Click(object sender, EventArgs e){
			dig.op(dig.operacija);
			dig.operacija = '-';
			this.Rezultat.Text = dig.rezultat.ToString();
		}

		private void DugmeJednako_Click(object sender, EventArgs e){
			dig.op(dig.operacija);
			dig.operacija = '=';
			this.Rezultat.Text = dig.rezultat.ToString();
		}

		private void DugmeZarez_Click(object sender, EventArgs e){
			if (dig.trenutni != "")
				dig.trenutni += '.';
			this.Rezultat.Text = dig.trenutni;
		}

		private void DugmeReset_Click(object sender, EventArgs e){
			this.dig.reset();
			this.Rezultat.Text = "0";
		}

		private void rezultat_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape:
					{
						this.dig.reset();
						this.Rezultat.Text = "0";
					}
					break;
				case Keys.Add:
					{
						this.Sabiranje_Click(sender, e);
					}
					break;
				case Keys.Subtract:
					{
						this.Oduzimanje_Click(sender, e);
					}
					break;
				case Keys.Multiply:
					{
						this.Mnozenje_Click(sender, e);
					}
					break;
				case Keys.Divide:
					{
						this.Deljenje_Click(sender, e);
					}
					break;

				case Keys.Decimal:
					{
						this.DugmeZarez_Click(sender, e);
					}
					break;
				case Keys.NumPad0:
					{
						dig.trenutni += "0";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad1:
					{
						dig.trenutni += "1";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad2:
					{
						dig.trenutni += "2";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad3:
					{
						dig.trenutni += "3";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad4:
					{
						dig.trenutni += "4";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad5:
					{
						dig.trenutni += "5";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad6:
					{
						dig.trenutni += "6";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad7:
					{
						dig.trenutni += "7";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad8:
					{
						dig.trenutni += "8";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
				case Keys.NumPad9:
					{
						dig.trenutni += "9";
						this.Rezultat.Text = dig.trenutni;
					}
					break;
			}
			if (e.Control)
			{
				//this.Cursor = Cursors.WaitCursor;
				switch (e.KeyCode)
				{
					case Keys.C:
						{
							this.Close();
						}
						break;
					case Keys.Enter:
						{
							this.DugmeJednako_Click(sender, e);
						}
						break;
				}
			}
		}

		private void Dugme7_KeyDown(object sender, KeyEventArgs e)
		{
			rezultat_KeyDown(sender, e);
		}
	}
}

