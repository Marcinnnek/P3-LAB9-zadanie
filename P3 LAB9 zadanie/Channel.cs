using System;
using System.Collections.Generic;
using System.Text;

namespace P3_LAB9_zadanie
{
    public class Channel
    {
        private int _channelId;
        private string _channelName;
        private int _viewMeter;
        private int _licznikSubow;

        public event EventHandler<OpublikowanoFilmEventArgs> OpublikowanoFilm; // Dodano Event OpublikowanoFilm

        public Channel(int channelId, string channelName)
        {
            ChannelId = channelId;
            ChannelName = channelName;
        }

        public void WyswietlFilm(int id)
        {
            _viewMeter++;
            Console.WriteLine($"Wyświetlono film o id: {id}, liczba wyświetlneń: {ViewMeter} (Channel)");
        }

        public void OpublikujFilm()
        {
            Console.WriteLine($"Opublikowano film! (Channel)");

            OpublikowanoFilm?.Invoke(this, new OpublikowanoFilmEventArgs() { NazwaKanalu = ChannelName, IdKanalu = ChannelId }); // Publikacja Eventu OpublikowanoFilm
        }
        public void LicznikSubow()
        {
            _licznikSubow++;
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
                return _channelName;
            }
            set
            {
                _channelName = value;
            }
        }
        public int LicznikSubskrybcji
        {
            get
            {
                return _licznikSubow;
            }
        }
    }
}
