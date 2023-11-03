using System;

namespace lesson
{
    class Song
    {
        public string song;
        public string singer;
        public string album;
        public int year;
    }

    class Program
    {
        public static void Print(string song, string singer, string album, int year)
        { 
            Console.WriteLine("Название: " + song);
            Console.WriteLine("Исполнитель: " + singer);
            Console.WriteLine("Альбом: " + album);
            Console.WriteLine("Год выпуска: " + year);
            Console.WriteLine("  ");
        }

        public static string GetName(string prompt)
        { 
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        public static int GetNumber(string prompt)
        {
            Console.WriteLine(prompt);
            return Convert.ToInt32(Console.ReadLine());
        }

        public static void Main(string[] args)
        {
            Song b1 = new Song();
            Console.WriteLine("Напишите название песни, исполнителя, альбом и год выпуска: ");
            b1.song = GetName("Песня: ");
            b1.singer = GetName("Исполнитель: ");
            b1.album = GetName("Альбом: ");
            b1.year = GetNumber("Год выпуска: ");

            Print(b1.song, b1.singer, b1.album, b1.year);
        }
    }
}
