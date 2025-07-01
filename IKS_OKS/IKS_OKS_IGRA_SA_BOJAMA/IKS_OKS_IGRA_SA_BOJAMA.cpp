#include "pch.h"
#include <iostream>
#include <string>
#include <Windows.h>



using namespace std;



void text(int text_color = 7, int paper_color = 0)
{
	// defaults to light_gray on black
	int color_total = (text_color + (paper_color * 16));
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),
		color_total);
}

void TTT_Piece(char piece)
{
	if (piece == 'X')
	{
		text(9, 0);
	}
	else if (piece == 'O')
	{
		text(10, 0);
	}
	else
		text(14, 0);
}

char tabla[3][3] = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
char potez = 'X';
int red, kolona;
bool izjednaceno = false;

//Tabla
void prikaz_table()
{
	system("CLS");
	char piece;
	text(15, 0);
	cout << "\t\t\t\t ************************** IKS--OKS IGRA *************************\n\n";


	cout << "\t\t\t\t\t\t\t _____ _____ _____\n";
	cout << "\t\t\t\t\t\t\t|     |     |     |\n";
	cout << "\t\t\t\t\t\t\t|  ";
	piece = tabla[0][0];
	TTT_Piece(piece);
	cout << tabla[0][0];
	text(15, 0);
	cout << "  |  ";
	piece = tabla[0][1];
	TTT_Piece(piece);
	cout << tabla[0][1];
	text(15, 0);
	cout << "  |  ";
	piece = tabla[0][2];
	TTT_Piece(piece);
	cout << tabla[0][2];
	text(15, 0);
	cout << "  |\n";
	cout << "\t\t\t\t\t\t\t|_____|_____|_____| \n";
	cout << "\t\t\t\t\t\t\t|     |     |     |\n";
	cout << "\t\t\t\t\t\t\t|  ";
	piece = tabla[1][0];
	TTT_Piece(piece);
	cout << tabla[1][0];
	text(15, 0);
	cout << "  |  ";
	piece = tabla[1][1];
	TTT_Piece(piece);
	cout << tabla[1][1];
	text(15, 0);
	cout << "  |  ";
	piece = tabla[1][2];
	TTT_Piece(piece);
	cout << tabla[1][2];
	text(15, 0);
	cout << "  |\n";
	cout << "\t\t\t\t\t\t\t|_____|_____|_____|\n";
	cout << "\t\t\t\t\t\t\t|     |     |     |\n";
	cout << "\t\t\t\t\t\t\t|  ";
	piece = tabla[2][0];
	TTT_Piece(piece);
	cout << tabla[2][0];
	text(15, 0);
	cout << "  |  ";
	piece = tabla[2][1];
	TTT_Piece(piece);
	cout << tabla[2][1];
	text(15, 0);
	cout << "  |  ";
	piece = tabla[2][2];
	TTT_Piece(piece);
	cout << tabla[2][2];
	text(15, 0);
	cout << "  |\n";
	cout << "\t\t\t\t\t\t\t|_____|_____|_____| \n";
}

// IGRA U TOKU
void igra_u_toku() {


	int polje;

	if (potez == 'X') {
		cout << "Igrac 1 na potezu [X]: ";
		cin >> polje;

	}
	else if (potez == 'O') {
		cout << "Igrac 2 na potezu [O]: ";
		cin >> polje;

	}

	//cin >> polje;

	switch (polje) {
	case 1: red = 0; kolona = 0; break;
	case 2: red = 0; kolona = 1; break;
	case 3: red = 0; kolona = 2; break;
	case 4: red = 1; kolona = 0; break;
	case 5: red = 1; kolona = 1; break;
	case 6: red = 1; kolona = 2; break;
	case 7: red = 2; kolona = 0; break;
	case 8: red = 2; kolona = 1; break;
	case 9: red = 2; kolona = 2; break;
	}

	if (potez == 'X' && tabla[red][kolona] != 'X' && tabla[red][kolona]
		!= 'O') {
		tabla[red][kolona] = 'X';
		potez = 'O';
	}
	else if (potez == 'O' && tabla[red][kolona] != 'X' &&
		tabla[red][kolona] != 'O') {
		tabla[red][kolona] = 'O';
		potez = 'X';
	}
	else {
		cout << "To polje je zauzeto.Pokusajte sa drugim poljem.\n";
		igra_u_toku();
	}
	prikaz_table();
}

//KRAJ IGRE
bool kraj_igre() {

	for (int i = 0; i < 3; i++) {

		if ((tabla[i][0] == tabla[i][1] && tabla[i][0] == tabla[i][2]) ||
			(tabla[0][i] == tabla[1][i] && tabla[0][i] == tabla[2][i]) ||
			(tabla[0][0] == tabla[1][1] && tabla[1][1] == tabla[2][2]) ||
			(tabla[0][2] == tabla[1][1] && tabla[1][1] == tabla[2][0])) {
			return false;
		}
	}

	for (int i = 0; i < 3; i++) {

		for (int j = 0; j < 3; j++) {

			if (tabla[i][j] != 'X' && tabla[i][j] != 'O') {
				return true;
			}
		}
	}

	izjednaceno = true;
	return false;
}


int main()
{
	char odluka = 'd';
	bool ok;
	do
	{
		do {
			prikaz_table();
			igra_u_toku();
			ok = kraj_igre();

			if (potez == 'X' && izjednaceno == false)
			{
				//system("CLS");
				cout << "DRUGI IGRAC JE POBEDIO [O] !!!!!!!!!!!!!!\n";

			}
			else if (potez == 'O' && izjednaceno == false) {
				cout << "PRVI IGRAC JE POBEDIO [X] !!!!!!!!!!!!!!!\n";

			}
			else if (izjednaceno == true) {
				cout << "IGRA JE IZJEDNACENA!!!!!!!!!!\n";
				izjednaceno = false;
			}
		} while (ok);

		do
		{
			cout << "\nDa li zelite da igrate opet [DA] - d ili [NE] - n : ";

			cin >> odluka;

			if (odluka != 'd' && odluka != 'n')
			{
				cout << "Uneli ste nepostojeci simbol. Pokusajte ponovo.\n";
			}
		} while (odluka != 'd' && odluka != 'n');
		int x = 1;
		for (int i = 0; i < 3; i++) //  New game. Reset the array to orifginal values

		{
			for (int j = 0; j < 3; j++)
			{
				tabla[i][j] = '0' + x;
				x++;
			}

		}
	} while (odluka == 'd');

	if (odluka == 'n') {
		return 0;
	}

	system("PAUSE");
	return 0;
}
