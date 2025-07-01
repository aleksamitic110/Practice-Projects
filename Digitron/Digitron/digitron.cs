using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digitron
{
	public class digitron
	{
		public double rezultat;
		public string izraz;
		public char operacija;
		public double prvi;
		public double drugi;
		public string trenutni;

		public digitron(){
			this.rezultat = 0.0;
			this.izraz = "";
			this.operacija = ' ';
			this.prvi = 0.0;
			this.drugi = 0.0;
			this.trenutni = "";
		}

		public void op(char znak){
			switch (znak) {
				case ' ': {
					if (this.trenutni != ""){
						this.rezultat = Convert.ToDouble(this.trenutni);
						this.trenutni = "";
					}
				}break;
				case '+': {
					if (this.trenutni != "") {
						this.prvi = this.rezultat;
						this.drugi = Convert.ToDouble(this.trenutni);
						this.trenutni = "";
						this.rezultat = this.prvi + this.drugi;
					}
				}break;
				case '-':{
					if (this.trenutni != ""){
						this.prvi = this.rezultat;
						this.drugi = Convert.ToDouble(this.trenutni);
						this.trenutni = "";
						this.rezultat = this.prvi - this.drugi;
					}
				}break;
				case '*':{
					if (this.trenutni != ""){
						this.prvi = this.rezultat;
						this.drugi = Convert.ToDouble(this.trenutni);
						this.trenutni = "";
						this.rezultat = this.prvi * this.drugi;
					}
				}break;
				case '/':{
					if (this.trenutni != ""){
						this.prvi = this.rezultat;
						this.drugi = Convert.ToDouble(this.trenutni);
						this.trenutni = "";
						this.rezultat = this.prvi / this.drugi;
					}
				}break;
				case '=':{
					this.izraz = "";
					this.operacija = ' ';
					this.prvi = 0.0;
					this.drugi = 0.0;
					this.trenutni = "";
				}break;
			}
		}

		public void reset() {
			this.rezultat = 0.0;
			this.izraz = "";
			this.operacija = ' ';
			this.prvi = 0.0;
			this.drugi = 0.0;
			this.trenutni = "";
		}

	}
}
