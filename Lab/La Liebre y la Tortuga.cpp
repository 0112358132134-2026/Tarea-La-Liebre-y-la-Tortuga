#include "pch.h"
#include "cstdlib"
#include "string"
#include "ctime"
using namespace System;

void CambiarPos(int Map[70], int Probabilidad[10], int** Gamer) {
	int Value = rand() % 10;
	int NuevaPos = **Gamer + Probabilidad[Value];
	NuevaPos = NuevaPos >= 70 ? 69 : (NuevaPos < 0 ? 0 : NuevaPos);
	*Gamer = &Map[NuevaPos];
}
int main(array<System::String ^> ^args)
{
	//Posición inicial para random
	srand(time(NULL));
	//crear variables y asignar valor
	int  Map[70];
	int ProbabilidadTortuga[10] = { 3,3,3,3,3,-6,-6,1,1.1 };
	int ProbabilidadLiebre[10] = { 0,0,9,9,-12,1,1,1,-2,-2 };
	int* Tortuga, * Liebre;
	Liebre = Tortuga = &Map[0];
	for (int i = 0; i < 70; i++)
	{
		Map[i] = i + 1;
	}
	bool Fin = false;
	while (!Fin)
	{
		CambiarPos(Map, ProbabilidadTortuga, &Tortuga);
		CambiarPos(Map, ProbabilidadLiebre, &Liebre);
		for (int i = 0; i < 70; i++)
		{
			if (Tortuga == Liebre && Tortuga == &Map[i])
			{
				Console::Write("0");
			}
			else if (Tortuga == &Map[i])
			{
				Console::Write("T");
			}
			else if (Liebre == &Map[i])
			{
				Console::Write("L");
			}
			else
			{
				Console::Write("*");
			}

		}
		Console::WriteLine("");
		if (Tortuga == &Map[69])
		{
			Console::WriteLine("Gana Tortuga, Bravo!");
			Fin = true;
		}
		else if (Liebre == &Map[69]) {
			Console::WriteLine("Gana Liebre, Sin palabras!");
			Fin = true;
		}
	}

	Console::ReadKey();
    return 0;
}
