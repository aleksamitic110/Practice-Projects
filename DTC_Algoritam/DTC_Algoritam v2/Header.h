#pragma once
#include <string.h>
#include <iostream>
#include <cstdlib>
#include <vector>
#include <algorithm>

using namespace std;
class DTC {
protected:
	char **mat;

	vector<char**> matrice;
	vector<int> rows;
	vector<int> columns;
	bool vise;
	int velicinaX;
	int velicinaY;

public:



	DTC(int velicinaX, int velicinaY, string recenica, vector<int> rows, vector<int> columns) {

		vise = false;
		this->rows = rows;
		this->columns = columns;
		int duzina = recenica.size();
		
		this->velicinaX = velicinaX;
		this->velicinaY = velicinaY;

		this->mat = (char **)malloc(velicinaX * sizeof(char *));

		for (int i = 0; i < velicinaX; i++)
			this->mat[i] = (char*)malloc(velicinaY * sizeof(char));

		if (duzina <= 25) {
			for (int i = 0; i < velicinaX; i++) {
				for (int j = 0; j < velicinaY; j++)
					if (i * velicinaX + j < duzina)
						this->mat[i][j] = recenica[i * velicinaX + j];
					else
						this->mat[i][j] = '#';
			}
		}
		else {
			int velMat = this->velicinaX * this->velicinaY;
			int brojMat = duzina / velMat + 1;

			matrice = vector<char**>(brojMat);
			vise = true;

			for (int k = 0; k < brojMat; k++) {
				this->matrice[k] = (char **)malloc(velicinaX * sizeof(char *));

				for (int i = 0; i < velicinaX; i++)
					this->matrice[k][i] = (char*)malloc(velicinaY * sizeof(char));
			}

			for (int k = 0; k < brojMat; k++) {

				for (int i = 0; i < velicinaX; i++) {
					for (int j = 0; j < velicinaY; j++)
						if (i * velicinaX + j < duzina && i * velicinaX + j + k * velMat <= duzina)
							this->matrice[k][i][j] = recenica[i * velicinaX + j + k * velMat];
						else
							this->matrice[k][i][j] = '#';
				}
			}
		}
	}

	void ShiftRows(bool prevedi) {

		if (!vise) {
			char *swap;
			// True -> kriptovanje
			if (prevedi) {
				for (int i = 0; i < rows.size(); i += 2) {

					swap = this->mat[rows[i] - 1];
					this->mat[rows[i] - 1] = this->mat[rows[i + 1] - 1];
					this->mat[rows[i + 1] - 1] = swap;

				}
			}
			//False -> dekriptovanje
			else {
				for (int i = rows.size() - 1; i > 0; i -= 2) {

					swap = this->mat[rows[i] - 1];
					this->mat[rows[i] - 1] = this->mat[rows[i - 1] - 1];
					this->mat[rows[i - 1] - 1] = swap;

				}
			}
		}
		else {
			for (int k = 0; k < matrice.size(); k++) {
				char *swap;
				// True -> kriptovanje
				if (prevedi) {
					for (int i = 0; i < rows.size(); i += 2) {

						swap = this->matrice[k][rows[i] - 1];
						this->matrice[k][rows[i] - 1] = this->matrice[k][rows[i + 1] - 1];
						this->matrice[k][rows[i + 1] - 1] = swap;

					}
				}
				//False -> dekriptovanje
				else {
					for (int i = rows.size() - 1; i > 0; i -= 2) {

						swap = this->matrice[k][rows[i] - 1];
						this->matrice[k][rows[i] - 1] = this->matrice[k][rows[i - 1] - 1];
						this->matrice[k][rows[i - 1] - 1] = swap;

					}
				}
			}
		}
	}
	void ShiftColumns(bool prevedi) {

		if (!this->vise) {
			char swap;
			//True -> enkripcija
			if (prevedi) {
				for (int i = 0; i < columns.size(); i += 2)
					for (int j = 0; j < this->velicinaY; j++) {
						swap = this->mat[j][columns[i] - 1];
						mat[j][columns[i] - 1] = this->mat[j][columns[i + 1] - 1];
						mat[j][columns[i + 1] - 1] = swap;
					}
			}
			//Flase -> dekripcija
			else {
				for (int i = columns.size() - 1; i > 0; i -= 2)
					for (int j = 0; j < this->velicinaY; j++) {
						swap = this->mat[j][columns[i] - 1];
						mat[j][columns[i] - 1] = this->mat[j][columns[i - 1] - 1];
						mat[j][columns[i - 1] - 1] = swap;
					}
			}
		}
		else {
			for (int k = 0; k < matrice.size(); k++) {
				char swap;
				//True -> enkripcija
				if (prevedi) {
					for (int i = 0; i < columns.size(); i += 2)
						for (int j = 0; j < this->velicinaY; j++) {
							swap = this->matrice[k][j][columns[i] - 1];
							this->matrice[k][j][columns[i] - 1] = this->matrice[k][j][columns[i + 1] - 1];
							this->matrice[k][j][columns[i + 1] - 1] = swap;
						}
				}
				//Flase -> dekripcija
				else {
					for (int i = columns.size() - 1; i > 0; i -= 2)
						for (int j = 0; j < this->velicinaY; j++) {
							swap = this->matrice[k][j][columns[i] - 1];
							this->matrice[k][j][columns[i] - 1] = this->matrice[k][j][columns[i - 1] - 1];
							this->matrice[k][j][columns[i - 1] - 1] = swap;
						}
				}
			}
		}
	}
	void Kripto(bool provera) {
		ShiftRows(provera);
		ShiftColumns(provera);
	}
	string Zastiti(bool provera) {
		Kripto(provera);
		string recenica;

		if (!this->vise) {
			for (int i = 0; i < velicinaY; i++)
				for (int j = 0; j < velicinaX; j++)
					recenica += this->mat[i][j];
		}
		else {
			for (int k = 0; k < matrice.size(); k++) {
				for (int i = 0; i < velicinaY; i++)
					for (int j = 0; j < velicinaX; j++)
						recenica += this->matrice[k][i][j];
			}
		}
		recenica.erase(remove(recenica.begin(), recenica.end(), '#'), recenica.end());
		return recenica;
	}
	void print() {
		for (int i = 0; i < this->velicinaX; i++) {
			for (int j = 0; j < this->velicinaY; j++)
				cout << this->mat[i][j] << " ";
			cout << endl;
		}
	}

};