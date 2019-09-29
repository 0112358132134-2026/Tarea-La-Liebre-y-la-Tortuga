#include <iostream>
#include<conio.h>
#include<stdlib.h>
#include<time.h>
using namespace std;

struct Carta
{
	char color;
	int número;
	Carta* siguiente;
}; 

void agregarCarta(Carta *&pila, char a, int n)
{
	Carta* nuevaCarta = new Carta();
	nuevaCarta->color = a;
	nuevaCarta->número = n;
	nuevaCarta->siguiente = pila;
	cout << "\nElemento " << a << " y elemento " << n << " agregado a CARTA correctamente";
}

int main()
{
	//Declaracion de variable null
	Carta* pila = NULL;

	//Declaracion de variables a usar
	int n1, n2;
	char b, c;
	int random1, random2;

	//Random para las cartas
	srand(time(NULL));
	random1 = rand() % 6 + 1;

	//Ingreso del usuario
	cout << "Digite un numero:";
	cin >> n1;
	cout << "Digite la letra de la carta:";
	cin >> b;
	agregarCarta(pila, b, n1);
	
	cout << "XD";
	cin >> n1;

}
