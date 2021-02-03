using System;
using System.Collections.Generic;
using System.Text;

namespace P3_LAB9_zadanie
{
    public class OpublikowanoFilmEventArgs:EventArgs
    {
        public string NazwaKanalu { get; set; }
        public int IdKanalu { get; set; }
    }
}
