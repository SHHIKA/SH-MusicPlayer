using SH_MusicPlayer.Lib.Files;
using SH_MusicPlayer.Lib;
using System;

namespace SH_MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(string.Join(", ", Data.load("D:\\test.txt")));

            Player player = new Player("D:\\test.txt");
            player.Play();

            Console.ReadKey();
        }
    }
}
