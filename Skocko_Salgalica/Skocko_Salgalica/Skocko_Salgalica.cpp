#include "pch.h"
#include <iostream>
#include <cstdlib>
#include <string>
#include <algorithm>
#include <ctime>
#include <vector>
#include<Windows.h>
#include <chrono>



//Pozivanje funkcija

std::string random_string(size_t length);
void IspisTablicePogodjenih(std::vector<int> _tablica_pogodjenih);
bool Provera_POGEODJENI_NEPOGODJENI_POBEDE(std::string _kombinacija_pokusaja, std::string _zadata_kombinacija, bool _nema_znakova, std::vector<int> &_tablica_pogodjenih, int &_brojac_tacnih, int &broj_nisu_na_mestu, std::string _sva_cetiri);
void ResetovanjeTablice(std::vector<int> &_Tabla_Pogodjenih);

//-----------------------------------------------------------------------------------------------------------------------------

int main() {
	

	// Ukljucuje Caps lock ako nije ukljucen
	BYTE kbrd[256];
	GetKeyboardState(kbrd);
	bool bCapsLock = kbrd[VK_CAPITAL] ? true : false;
	  

	if (bCapsLock == false) {
		keybd_event(VK_CAPITAL, 0, KEYEVENTF_EXTENDEDKEY | 0, 0);
		keybd_event(VK_CAPITAL, 0, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
	}

	// Varijable
	int brojac_tacnih = 0, broj_nisu_na_mestu = 0;
	bool nema_znakova = true, provera_pobede = true;
	std::string zadata_kombinacija, kombinacija_pokusaja, sva_cetiri;
	char nova_igra;
	std::vector<int> tablica_pogodjenih(4);

	// Zadavanje kombinacije (random funkcija zadaje kombinaciju koja je tipa string)
	srand(time(NULL));
	zadata_kombinacija = random_string(4);


	// Za povecavanje slova i menjanje fonta *(ne koristim)
	CONSOLE_FONT_INFOEX cfi;
	cfi.cbSize = sizeof(cfi);
	cfi.nFont = 0;
	cfi.dwFontSize.X = 0;                   // Sirina
	cfi.dwFontSize.Y = 45;                  // Visina
	cfi.FontFamily = FF_DONTCARE;
	cfi.FontWeight = FW_NORMAL;
	wcscpy_s(cfi.FaceName, L"New Times Roman"); // Biranje fonta
	SetCurrentConsoleFontEx(GetStdHandle(STD_OUTPUT_HANDLE), FALSE, &cfi);

	// Objasnjenje igre i start igre
	char startIgre;
	std::cout << "Igrate igru Skocko (kombinacija se sastoji od 4 znaka).\n\n";
	std::cout << "Unesite\n S-skocko\n T-tref\n P-pik\n H-herc\n K-kocka\n Z-zvezda\n\n";

novi_unos:
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
	std::cout << "Unesite 1 za start igre ili 0 za izlaz: ";
	std::cin >> startIgre;

	if (startIgre == '1')
		system("CLS");
	else if (startIgre == '0')
		return 0;
	else {
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 4);
		std::cout << "Uneli ste nepostojeci znak. Unesite ponovo.\n\n";
		goto novi_unos;
	}

	// PETLJA IGRE
	for (int i = 0; i <= 6; i++) {

novi_pokusaj_unosa:
		// Postavlja boju kobminacije na belu i pozadinu na crnu
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 14);
		std::cout << i + 1 << ". ";
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 15);

		// Unos kombinacije i provera validnosti
		std::cin >> kombinacija_pokusaja;

		if (kombinacija_pokusaja.size() != 4) {
			std::cout << "Napravili ste gresku u unosu pokusajte ponovo.\n\n";
				goto novi_pokusaj_unosa;
		}

		// Provera POGODJENIH i NEPOGODJENIH i POBEDE
		bool kraj = Provera_POGEODJENI_NEPOGODJENI_POBEDE(kombinacija_pokusaja, zadata_kombinacija, nema_znakova, tablica_pogodjenih, brojac_tacnih, broj_nisu_na_mestu, sva_cetiri);
			
		if (kraj)
			return 0;

		// Ispis tablice pogodjenih
		std::cout << "   ";
		IspisTablicePogodjenih(tablica_pogodjenih);

		// Resetovanje Podataka
		ResetovanjeTablice(tablica_pogodjenih);
		brojac_tacnih = 0;
		broj_nisu_na_mestu = 0;
		nema_znakova = true;
		//provera_pobede = true;

		std::cout << std::endl;
		std::cout << std::endl;
	}

	// Ukoliko kombinacija nije pogodjena

	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_GREEN);
	std::cout << std::endl;
	std::cout << "NISTE POGODILI !!!!! tacna kombinacija je ";
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_RED);
	std::cout << zadata_kombinacija;

	std::cout << std::endl << std::endl;
	system("PAUSE");
	return 0;
}

//-----------------------------------------------------------------------------------------------------------------------------

// Pravljenje funkcija

std::string random_string(size_t length)
{
	auto randchar = []() -> char
	{
		const char charset[] = "STPKHZ";

		const size_t max_index = (sizeof(charset) - 1);
		return charset[rand() % max_index];
	};
	std::string str(length, 0);
	std::generate_n(str.begin(), length, randchar);
	std::cout << str << std::endl;
	return str;
}

void IspisTablicePogodjenih(std::vector<int> _tablica_pogodjenih) {
	for (int i = 0; i < _tablica_pogodjenih.size(); i++) {
		if (_tablica_pogodjenih[i] == 1)
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_RED);
		else if (_tablica_pogodjenih[i] == 2)
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), 6);
		else
			SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_INTENSITY);

		std::cout << "O";
	}
}


bool Provera_POGEODJENI_NEPOGODJENI_POBEDE(std::string _kombinacija_pokusaja, std::string _zadata_kombinacija, bool _nema_znakova, std::vector<int> &_tablica_pogodjenih, int &_brojac_tacnih, int &_broj_nisu_na_mestu, std::string _sva_cetiri) {

	// Pomocne varijable za pronalazenje tacnih znakova koji nisu na pravom mestu
	std::string pomocna_zadata = _zadata_kombinacija;
	std::string pomocna_pokusaja = _kombinacija_pokusaja;
	int brojac1 = 0;

	// Ukoliko nema znakova onda tablicu pogodjenih postavljamo na nule (0000)
	for (int i = 0; i < 4; i++)
			if (_kombinacija_pokusaja[i] == _zadata_kombinacija[i])
				_nema_znakova = false;

	if (_nema_znakova) {
		for (int i = 0; i < 4; i++) {
			_tablica_pogodjenih[i] = 0;
		}
	}

	//Ukoliko ima tacnih (na pravom su mestu) dodajemo tablici_pogodjenih jedinice (oniliko koliko ima znakova na pravom mestu)
	else {

		for (int i = 0; i < 4; i++) {
			if (_zadata_kombinacija[i] == _kombinacija_pokusaja[i]) {
				_brojac_tacnih++;

				// Umesto tacnih znakova iz stringova stavljam *
				pomocna_zadata[i] = '*';
				pomocna_pokusaja[i] = '*';
			}
		}

		for (int i = 0; i < _brojac_tacnih; i++) {
			_tablica_pogodjenih[i] = 1;
		}
	}

	// Ukoliko ima znakova koji nisu na pravom mestu, tablici_pogodjenih dodajemo dvojke (oniliko dvojki koliko ima znakova koji nisu na pravom mestu)

	// Brisanje *  i  uklanjanje karaktera iz pomocna_zadata i pomocna_pokusja
	if (_brojac_tacnih != 0) {
		pomocna_zadata.erase(std::remove(pomocna_zadata.begin(), pomocna_zadata.end(), '*'), pomocna_zadata.end());
		pomocna_pokusaja.erase(std::remove(pomocna_pokusaja.begin(), pomocna_pokusaja.end(), '*'), pomocna_pokusaja.end());
	}


	// Odredjuje broj znakova koji nisu na pravom mestu i oznacava ih sa *
	for (int i = 0; i < pomocna_zadata.size(); i++)
		for (int k = 0; k < pomocna_pokusaja.size(); k++)
			if ((pomocna_zadata[i] == pomocna_pokusaja[k]) && (pomocna_zadata[i] != '*')) {
				_broj_nisu_na_mestu++;
				pomocna_zadata[i] = '*';
				pomocna_pokusaja[k] = '*';
			}

	// Postavljanje tablice za znake koji nisu na pravom mestu
	if (_brojac_tacnih == 4) {
		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_RED);
		_sva_cetiri = "OOOO";
		std::cout << "   "<< _sva_cetiri << std::endl;

		SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), FOREGROUND_BLUE);
		std::cout << std::endl << "POGODILI STE TACNU KOMBINACIJU !!!!!!!! ( " << _zadata_kombinacija << " )" << std::endl;
		return  true;
	}
	else {
		for (int i = _brojac_tacnih; brojac1 < _broj_nisu_na_mestu; i++) {
			_tablica_pogodjenih[i] = 2;
			brojac1++;
		}
		return false;
	}

}

void ResetovanjeTablice(std::vector<int> &_Tabla_Pogodjenih) {
	for (int i = 0; i < 4; i++)
		_Tabla_Pogodjenih[i] = 0;
}
