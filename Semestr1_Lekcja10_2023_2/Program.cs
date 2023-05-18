using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr1_Lekcja10_2023_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //POWTÓRKA FOR

            // Napisz program, który policzy sumę wszystkich liczb mniejszych od podanej przez użytkownika
            // DO ZADANIA UŻYWAMY PĘTLI FOR
            //1. pobieramy liczbę od usera (liczba całkowita)
            //2. user podał np 6
            //3. obliczamy sumę wszystkich poprzednich liczb   suma = 6 + 5 + 4 + 3 + 2 + 1  zero już nie 
            //4. wypisujemy sumę

            int suma = 0;
            Console.WriteLine("Podaj liczbę całkowitą");
            int liczba = int.Parse(Console.ReadLine()); //6

            for (int x = liczba; x > 0; x--)// x = x - 1
            {
                suma = suma + x;
            }

            Console.WriteLine($"Suma wszystkich liczb poprzedzających {liczba} to {suma}");


            // PĘTLA WHILE

            for (int x = 1; x <= 10; x++)
            {
                Console.WriteLine(x);
            }


            int i = 1;
            while(i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.Clear();

            //while(true)
            //{
            //    Console.WriteLine("TEST");
            //}

            //Zadanie 1 - Dźwięk

            int czestotliwosc = 500;

            while (czestotliwosc <= 10000)
            {
                Console.WriteLine($"Aktualny dźwięk o częstotliwości {czestotliwosc}Hz");
                Console.Beep(czestotliwosc, 10);
                czestotliwosc = czestotliwosc + 500;
            }


            //Zadanie 2 - CD KEY
            // 45252 - 22144 - 52555 - 12412 - 12456

            // 1. Deklarujemy random do generowania liczb losowych   -  OK
            // 2. Pobieramy od usera info ile ma być kluczy
            // 3. deklarujemy 1 zmienną która będzie określać długość klucza   -  OK
            // 4. Ustawiamy zmienną startową dla pętli while     -   OK
            // 5. Używamy pętli while z odpowiednim warunkiem    -   OK
            // 6. W środku pętli tworzymy klucz                 -   OK

            Console.Clear();

            Console.WriteLine("Podjaj ilość kluczy do wygenerowania");
            int ilość = int.Parse(Console.ReadLine());
            Random random = new Random();

            while (ilość > 0) {
                int długość = 25;
                int liczbaZnaków = 0;
                string klucz = "";

                while (liczbaZnaków < długość)
                {
                    klucz = klucz + random.Next(0, 10);   /// od 0 do 9
                    liczbaZnaków++;
                    if (liczbaZnaków % 5 == 0 && liczbaZnaków < długość)
                    {
                        klucz = klucz + "-";
                    }
                }

                Console.WriteLine(klucz);
                ilość--;
            }

            int y = 5;
            do
            {
                Console.WriteLine("Witaj");
                y--;
            } while (y > 0);
             // pętla do while działa tak samo jak pętla while z różnicą że ZAWSZE wykona się przynajmniej 1 raz


            for(int x= 1; x <= 10; x++)
            {
                Console.WriteLine(x);
                if(x == 5)
                {
                    break;  // break służy do zatrzymywania pętli
                }
            }

            Console.ReadLine();
        }
    }
}
