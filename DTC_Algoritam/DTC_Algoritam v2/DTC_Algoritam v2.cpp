#include "pch.h"
#include <iostream>
#include <string>
#include <vector>
#include "Header.h"

using namespace std;

int main()
{
    string recenica;
    cout << "=== Permutaciona Enkripcija ===" << endl << endl;

    cout << "Unesite recenicu za enkripciju/dekripciju:" << endl;
    getline(cin, recenica);

    cout << endl << "Unesite broj permutacija po redu: ";
    int permutacijeReda;
    cin >> permutacijeReda;

    vector<int> redovi;
    cout << "Unesite " << permutacijeReda * 2 << " elemenata za permutacije redova (parovi indeksa):" << endl;
    for (int i = 0; i < permutacijeReda * 2; i++) {
        int pom;
        cin >> pom;
        redovi.push_back(pom);
    }

    cout << endl << "Unesite broj permutacija po kolonama: ";
    int permutacijeKolona;
    cin >> permutacijeKolona;

    vector<int> kolone;
    cout << "Unesite " << permutacijeKolona * 2 << " elemenata za permutacije kolona (parovi indeksa):" << endl;
    for (int i = 0; i < permutacijeKolona * 2; i++) {
        int pom;
        cin >> pom;
        kolone.push_back(pom);
    }

    cout << "\n----------------------------------------" << endl;

    DTC test(5, 5, recenica, redovi, kolone);

    cout << "Enkriptovana recenica je: " << endl;
    cout << ">> " << test.Zastiti(true) << endl << endl;

    cout << "Dekriptovana recenica je: " << endl;
    cout << ">> " << test.Zastiti(false) << endl;

    cout << "\n========================================" << endl;

    system("PAUSE");
    return 0;
}
