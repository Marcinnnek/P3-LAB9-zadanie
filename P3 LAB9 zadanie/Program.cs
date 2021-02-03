//Stwórz aplikację inspirowaną działaniem YouTube. Stwórz klasy Użytkownik i Kanał. 
//Do obu klas dodaj pola Nazwa i Id. Do klasy Kanał dodaj pole LicznikWyswietlen, metodę WyswietlFilm(int id), metodę OpublikujFilm i event OpublikowanoFilm. 
//Metoda WyświetlFilm powinna zwiększać ilość wyświetleń o 1. Metoda OpublikujFilm powinna publikować event. 
//Do klasy Użytkownik dodaj metodę SubskrybujKanał, która jako parametr przyjmie obiekt typu Kanał. 
//Metoda da powinna podpiąć Event Handler Użytkownika pod Event Kanału. 
//W event handlerze wypisz krótkie potwierdzenie, np. "użytkownik X otrzymał powiadomienie o nowym filmie". 
//Stwórz kolekcję użytkowników i 1 Kanał. Niech wszyscy użytkownicy subskrybują ten kanał. 
//Dodaj także ExtensionMethod dla typu Kanał, która wypisze na konsolę nazwę kanału, jego ilość subskrypcji i wyświetleń. Wywołaj Extension Method.
//Możesz dowolnie dostosować parametry metod, które nie zostały sprecyzowane,
//a także dowolnie zaimplementować klasę EventArgs eventu OpublikowanoFilm w taki sposób, aby uzyskać opisany efekt.


using System;
using System.Collections.Generic;

namespace P3_LAB9_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel kanal = new Channel(567, "U Gienka Gejmera");

            List<User> Uzyszkodnicy = new List<User>{
                                                     new User(111, "Użyszkodnik Heniek"),
                                                     new User(125, "Użyszkodnik Mirek"),
                                                     new User(213, "Użyszkodnik Leszek"),
                                                     new User(343, "Użyszkodnik Mietek"),
                                                     new User(421, "Użyszkodnik Stasiek")
                                                     };
            foreach (var item in Uzyszkodnicy)
            {
                item.SubskrybujKanał(kanal);
            }

            kanal.OpublikujFilm();

            kanal.WyswietlFilm(Uzyszkodnicy[0].UserId);
            kanal.WyswietlFilm(Uzyszkodnicy[2].UserId);
            kanal.WyswietlFilm(Uzyszkodnicy[4].UserId);
            kanal.WyswietlFilm(Uzyszkodnicy[2].UserId);

            Console.WriteLine("#############################################################");

            kanal.Wypisz();

        }
    }
}
