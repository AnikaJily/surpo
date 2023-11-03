using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
            Console.WriteLine("Песня: " + song);
            Console.WriteLine("Исполнитель: " + singer);
            Console.WriteLine("Альбом: " + album);
            Console.WriteLine("Год: " + year);
            Console.WriteLine("  ");
        }
        public static string name(string name)
        { 
            name = Console.ReadLine();
            return name;
        }
        public static int num(int num)
        {
            num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
        public static void Main(string[] args)
        {
            Song b1 = new Song();
            Console.WriteLine("Напишите песню, исполнителя, альбом и год: ");
            b1.song = name(b1.song);
            b1.singer = name(b1.singer);
            b1.album = name(b1.album);
            b1.year = num(b1.year);
            b2.song = name(b2.song);
            b2.singer = name(b2.singer);
            b2.album = name(b2.album);
            b2.year = num(b2.year);
            Print(b1.song, b1.singer, b1.album, b1.year);

        }

    }


};
