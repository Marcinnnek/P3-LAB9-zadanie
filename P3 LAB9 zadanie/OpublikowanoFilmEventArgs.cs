using System;
using System.Collections.Generic;
using System.Text;

namespace P3_LAB9_zadanie
{
    class OpublikowanoFilmEventArgs:EventArgs
    {
        public string NazwaUzytkownika { get; set; }
        public int IdUzytkownika { get; set; }
    }
}
