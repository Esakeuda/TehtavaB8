using System;

namespace TehtavaB8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä x ja y arvot
            Console.Write("Syötä x-arvo: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä y-arvo: ");
            int y = int.Parse(Console.ReadLine());

            // Suoritetaan laskutoimitus x *= y*5
            x *= y * 5;

            // Tulostetaan tulos
            Console.WriteLine("x = " + x);
        }
    }
}
