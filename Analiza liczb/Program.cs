// See https://aka.ms/new-console-template for more information
//🟢 Zadanie 1 – Analizator liczb (łatwe)

//Cel: pętle, tablice, logika, Console

//Treść:

//Poproś użytkownika, aby podał 5 liczb całkowitych (po jednej w każdej linii).

//Zapisz je do zwykłej tablicy.

//Po wczytaniu:

//wypisz wszystkie liczby,

//policz sumę,

//znajdź największą i najmniejszą liczbę,

//policz ile liczb jest parzystych, a ile nieparzystych.

//Wskazówki:

//użyj for,

//do sprawdzania parzystości: % 2,

//na start min i max ustaw jako pierwszą liczbę z tablicy.

using System;
class Program
{
    static void Main(string[] args)
    {
        int[] tablica = new int[5];
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine("\nProszę podaj " + (i + 1) + " liczbę całkowitą");
            tablica[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("\n" + tablica[0]);
        Console.WriteLine(tablica[1]);
        Console.WriteLine(tablica[2]);
        Console.WriteLine(tablica[3]);
        Console.WriteLine(tablica[4]);

        Console.WriteLine("\nSuma wszystkich liczb to: " + (tablica[0] + tablica[1] + tablica[2] + tablica[3] + tablica[4]));

        int min = tablica[0];
        int max = tablica[0];

        for (int i = 0; i < tablica.Length; i++)
        {
            if (tablica[i] > max)
            {
                max = tablica[i];
            }
            if (tablica[i] < min)
            {
                min = tablica[i];
            }
        }
        Console.WriteLine("Maksymalna wartość to " + max);
        Console.WriteLine("Minimalna wartość to " + min);

        int parzyste = 0;
        int nieparzyste = 0;

        for (int i = 0; i < tablica.Length; i++)
        {
            if (tablica[i] % 2 == 0)
            {
                parzyste = parzyste + 1;
            }
            if (tablica[i] % 2 == 1)
            {
                nieparzyste = nieparzyste + 1;
            }
        }
        Console.WriteLine("Liczby nieparzyste: " + nieparzyste);
        Console.WriteLine("Liczby parzyste: " + parzyste);
    }
}