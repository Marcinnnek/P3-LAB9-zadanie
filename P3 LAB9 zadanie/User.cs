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
            Console.WriteLine("Subskrybujesz kanał!");
            kanal.OpublikowanoFilm += Kanal_OpublikowanoFilm; // podpiecie EventHandlera Channel pod użytkownika
        }

        private void Kanal_OpublikowanoFilm(object sender, EventArgs e) // Event handler dla opublikowano film
        {
            Console.WriteLine($"Użytkownik {1} zasubskrybował twój kanał");

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
