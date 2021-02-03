using System;
using System.Collections.Generic;
using System.Text;

namespace P3_LAB9_zadanie
{
    public static class ExtensionMethod
    {
        public static void Wypisz(this Channel kanal)
        {
            Console.WriteLine($"ID kanału: {kanal.ChannelId}");
            Console.WriteLine($"Nazwa kanału: {kanal.ChannelName}");
            Console.WriteLine($"Ilość wyświetleń: {kanal.ViewMeter}");
            Console.WriteLine($"Subskrybcje: {kanal.LicznikSubskrybcji}");
        }
    }
}
