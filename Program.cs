using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ustadlar = new MyDictionary<int, string>();

            ustadlar.Add(155, "Friedrich Nietzsche");
            ustadlar.Add(186, "Ivan Pavlov");
            ustadlar.Add(112, "Sigmund Freud");
            ustadlar.Add(110, "Arthur Schopehauer");

            Console.WriteLine("Numarasi: " + ustadlar.Count);
            Console.WriteLine(ustadlar.Values);
            Console.WriteLine(ustadlar.Keys);
        }
    }
}
