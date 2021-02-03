using System;
using System.Collections.Generic;
using System.Text;

namespace P3_LAB9_zadanie
{
    class User
    {
        private int _userId;
        private string _userName;

        public User(int userId, string userName)
        {
            UserId = userId;
            UserName = userName;
        }

        public void SubskrybujKanał(Channel kanal)
        {
            Console.WriteLine("Subskrybujesz kanał! (User)");
            kanal.LicznikSubow();
            kanal.OpublikowanoFilm += Uzytkownik_OpublikowanoFilm; // podpiecie EventHandlera Channel pod użytkownika
        }

        private void Uzytkownik_OpublikowanoFilm(object sender, OpublikowanoFilmEventArgs e) 
        {
            // Event handler dla opublikowano film - (słuchacz) funkcja czeka na pojawienie się ewentu 
            //(jest instrukcją jak zareagować na pojawienie się eventu)

            Console.WriteLine($"Użytkownik id: {UserId}, {UserName} dostał powiadomienie o publikacji filmu! (User)");
            Console.WriteLine($"Na kanale: {e.NazwaKanalu}opublikowano film. (User)");
        }

        public int UserId
        {
            get
            {
                return _userId;
            }
            set
            {
                _userId = value;
            }
        }
            public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
    }
}
