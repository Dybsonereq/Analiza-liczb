<<<<<<< HEAD
﻿using System;
=======
using System;
>>>>>>> 80472fd08d8d2a87cfee73b81a85f23df80e031c

class Program
{
    static void Main(string[] args)
    {
<<<<<<< HEAD
        int[] liczby = Wczytywanie(5);

        Wyswietlanie(liczby);

        Analiza(liczby);
    }
     ///////////////////////////////////////////////
        static int[] Wczytywanie(int rozmiar)
        {
            int[] tablica = new int[rozmiar];
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine($"\nProszę podaj {i + 1} liczbę całkowitą:");
                while (!int.TryParse(Console.ReadLine(), out tablica[i]))
                {
                    Console.WriteLine("To nie jest poprawna liczba. Prosze podaj liczbę całkowitą.");
                }
            }
            return tablica;

        }

        /////////////////////////////////////////////
        static void Wyswietlanie(int[] tablica)
        {
            Console.WriteLine("\nTwoje liczby to:");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
        }
        ////////////////////////////////////////////
        static void Analiza(int[] tablica)
        {
            int suma = 0;
            int max = tablica[0];
            int min = tablica[0];
            int parzyste = 0;
            int nieparzyste = 0;
            for (int i = 0; i < tablica.Length; i++)
            {
                suma += tablica[i];

                if (tablica[i] > max) max = tablica[i];
                if (tablica[i] < min) min = tablica[i];
                if (tablica[i] % 2 == 0)
                {
                    parzyste += 1;
                }
                if (tablica[i] % 2 != 0)
                {
                    nieparzyste += 1;
                }
            }

            Console.WriteLine($"\nSuma wszystkich liczb to: {suma}");
            Console.WriteLine($"Maksymalna wartość to: {max}");
            Console.WriteLine($"Minimalna wartość to: {min}");
            Console.WriteLine($"Liczby parzyste: {parzyste}");
            Console.WriteLine($"Liczby nieparzyste: {nieparzyste}");
        }
    }

=======
        int[] tablica = new int[5];
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine($"\nProszę podaj {i + 1} liczbę całkowitą:");
            while (!int.TryParse(Console.ReadLine(), out tablica[i]))
            {
                Console.WriteLine("To nie jest poprawna liczba");
            }
        }
        Console.WriteLine("\nTwoje liczby to:");
        for (int i = 0; i < tablica.Length; i++)
        {
            Console.WriteLine(tablica[i]);
        }

        int suma = 0;
        int min = tablica[0];
        int max = tablica[0];
        int parzyste = 0;
        int nieparzyste = 0;

        for (int i = 0; i < tablica.Length; i++)
        {
            suma += tablica[i];

            if (tablica[i] > max) max = tablica[i];
            if (tablica[i] < min) min = tablica[i];
        }

            for (int i = 0; i < tablica.Length; i++)
            {
                if (tablica[i] % 2 == 0)
                {
                    parzyste += 1;
                }
                if (tablica[i] % 2 != 0)
                {
                    nieparzyste += 1;
                }

            }
            Console.WriteLine($"\nSuma wszystkich liczb to: {suma}");
            Console.WriteLine($"Maksymalna wartość to: {max}");
            Console.WriteLine($"Minimalna wartość to: {min}");
            Console.WriteLine($"Liczby parzyste: {parzyste}");
            Console.WriteLine($"Liczby nieparzyste: {nieparzyste}");
        
    }
}
>>>>>>> 80472fd08d8d2a87cfee73b81a85f23df80e031c
