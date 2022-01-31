using SH_MusicPlayer.Lib.Files;
using SH_MusicPlayer.Lib;
using System;

namespace SH_MusicPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SH-MusicPlayer");

            Console.WriteLine("Please write music folder path");

            string input = Console.ReadLine();

            Console.WriteLine(string.Join(", ", Data.load(input)));

            Player player = new Player(input);

            player.Play();

            Console.WriteLine(" ");
            Console.WriteLine("Playing music!");

            while (true)
            {
                input = Console.ReadLine();

                if(input == "stop")
                {
                    break;
                }

                switch (input)
                {
                    case "pause":
                        player.Pause();
                        Console.WriteLine("Paused");
                        break;

                    case "play":
                        player.Play();
                        Console.WriteLine("Playing");
                        break;

                    case "volume":
                        Console.Write("Volume: ");
                        player.Volume(Int32.Parse(Console.ReadLine()));
                        break;

                    case "next":
                        Console.WriteLine("Next music");
                        player.Next();
                        player.Play();
                        break;

                    case "back":
                        Console.WriteLine("Back music");
                        player.Back();
                        player.Play();
                        break;

                    default:
                        Console.WriteLine("not found tihs command: {0}", input);
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
