using System;
using System.Collections.Generic;
using System.Text;

namespace P3_LAB9_zadanie
{
    class Channel
    {
        private int _channelId;
        private string _userName;
        private int _viewMeter;

        public event EventHandler OpublikowanoFilm; // Dodano Event OpublikowanoFilm

 

        public Channel(int channelId, string channelName)
        {
            ChannelId = channelId;
            ChannelName = channelName;
        }

        public void WyswietlFilm(int id)
        {
            _viewMeter++;
            Console.WriteLine($"Wyświetlono film o id: {id}, liczba wyświetlneń: {ViewMeter}");
        }

        public void OpublikujFilm()
        {
            Console.WriteLine($"Opublikowano film!");
            OpublikowanoFilm?.Invoke(this, EventArgs.Empty); // Publikacja Eventu OpublikowanoFilm
        }



        public int ViewMeter
        {
            get
            {
                return _viewMeter;
            }
        }
        public int ChannelId
        {
            get
            {
                return _channelId;
            }
            set
            {
                _channelId = value;
            }
        }
        public string ChannelName
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
