using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Napisz aplikację, grę FizzBuzz. Gra ta na podstawie przekazanej liczby zwraca odpowiedni wynik.
Zasady gry:
-Jeżeli liczba użytkownika będzie podzielna przez 3 bez reszty, to powinien zostać zwrócony wynik „Fizz”.
-Jeżeli liczba użytkownika będzie podzielna przez 5 bez reszty, to powinien zostać zwrócony wynik „Buzz”.
-Jeżeli liczba użytkownika będzie podzielna przez 3 i przez 5 jednocześnie bez reszty, to powinien zostać zwrócony wynik „FizzBuzz”.
-Jeżeli liczba użytkownika nie będzie podzielna przez 3 ani przez 5 bez reszty, to wtedy zwracasz podaną liczbę.
Niech to będzie nowa metoda niestatyczna w osobnej klasie o nazwie FizzBuzz. Najlepiej jak sama metoda będzie zwracała string’a, który zostanie zwrócony i wyświetlony w klasie Program w metodzie Main.
*/

namespace FizzBuzzTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var FizzBuzzObj = new FizzBuzzClass();

            Console.WriteLine("Welcome in the FizzBuzzTheGame!\nPress ALT+F4 if you want to close the app.");

            while (true)
            {
                Console.WriteLine("\nType your number:");
                if (int.TryParse(Console.ReadLine(), out int userNum))
                {

                    FizzBuzzObj.UserNum = userNum;

                    Console.WriteLine(FizzBuzzObj.FizzBuzz());

                    continue;
                }
                else
                {
                    Console.WriteLine("It's not the number (or this number out of range)!");
                    continue;
                }
            }

            Console.ReadLine();
        }

    }
}
