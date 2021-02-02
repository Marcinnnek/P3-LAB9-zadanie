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

namespace P3_LAB9_zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel kanal = new Channel(567, "U Gienka");
            User user0 = new User(832, "Użyszkodnik 1");
            User user1 = new User(8322, "Użyszkodnik 2");
            User user2 = new User(8322, "Użyszkodnik 2");


            user0.SubskrybujKanał(kanal);
            user1.SubskrybujKanał(kanal);
            user2.SubskrybujKanał(kanal);


            kanal.OpublikujFilm();


        }
    }
}
