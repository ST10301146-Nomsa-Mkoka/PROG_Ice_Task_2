using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace PROG_Ice_Task_2
{
    class WorkerClass
    {
        public WorkerClass() 
        {
        }

        public void dropDownMenu()
        {
            while (true) //while loop that will run until the user chooses to exit teh application
            {
                Console.WriteLine("User's WAV's file:");
                Console.WriteLine("********************");
                Console.WriteLine("Please select which audio you would like to play:");//will provide the user with a menu
                Console.WriteLine("(1) WAV 1"); //when user enters 1 wav file 1 will play
                Console.WriteLine("(2) WAV 2"); //when user enters 2 wav file 2 will play
                Console.WriteLine("(3) WAV 3"); //when user enters 3 wav file 3 will play
                Console.WriteLine("(4) Enter 4 to exit the program");
                Console.WriteLine("Please input the number of your choice");
                Console.WriteLine();

                int decision = int.Parse(Console.ReadLine()); //name of switch choice wich will be what the user will 

                switch (decision)
                {
                    case 1:
                        PlaySong1();
                        Console.ReadLine();
                        break;
                    case 2:
                        PlaySong2();
                        Console.ReadLine();
                        break;
                    case 3:
                        PlaySong3();
                        Console.ReadLine();
                        break;
                    case 4:
                        Environment.Exit(0);//will exit the program
                        break;
                }
            }
        }

        public void PlaySong1() 
        {
            Console.WriteLine("Playing Song...");
            string songsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Songs","sunflower-street-drumloop-85bpm-163900 (1).wav");

            if (File.Exists(songsFilePath))
            {
                Console.WriteLine($"File found at: {songsFilePath}");
                SoundPlayer player = new SoundPlayer(songsFilePath);
                Console.BackgroundColor = ConsoleColor.Green;
                player.PlaySync();
            }
            else
            {
                Console.WriteLine($"File not found: {songsFilePath}");
            }
        }

        public void PlaySong2()
        {
            Console.WriteLine("Playing Song...");
            string songsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Songs", "pianos-by-jtwayne-7-174717.wav");

            if (File.Exists(songsFilePath))
            {
                Console.WriteLine($"File found at: {songsFilePath}");
                SoundPlayer player = new SoundPlayer(songsFilePath);
                Console.BackgroundColor = ConsoleColor.Green;
                player.PlaySync();
            }
            else
            {
                Console.WriteLine($"File not found: {songsFilePath}");
            }
        }

        public void PlaySong3()
        {
            Console.WriteLine("Playing Song...");
            string songsFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Songs", "clean-trap-loop-131bpm-136738.wav");

            if (File.Exists(songsFilePath))
            {
                Console.WriteLine($"File found at: {songsFilePath}");
                SoundPlayer player = new SoundPlayer(songsFilePath);
                
                player.PlaySync();
            }
            else
            {
                Console.WriteLine($"File not found: {songsFilePath}");
            }
        }

       /* public void changeColor()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
        */




    }
}
