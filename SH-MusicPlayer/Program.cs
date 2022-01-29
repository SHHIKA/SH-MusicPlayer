using SH_MusicPlayer.Lib.Files;
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

            player.SetMusic("D:\\cover\\Claw My Heart.mp3");

            player.Play();

            Console.ReadKey();
        }
    }
}
