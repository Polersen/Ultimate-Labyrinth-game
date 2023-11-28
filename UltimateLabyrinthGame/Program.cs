﻿namespace UltimateLabyrinthGame
{


    

    internal class Program
    {

        public static Player player;

        public static void Main(string[] args)
        {
            player = new Player();
            player.GoToRoom(UltimateLabyrinth.description[0]);

            player.inventory.Add(new Items("1", "Key", "It's an ugly key", true, false));

            MovementLoop();
        }

        public static void MovementLoop()
        {
            do
            {
                var keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    player.UseDoor(player.CurrentRoom.North);
                }
                else if (keypress.Key == ConsoleKey.DownArrow)
                {
                    player.UseDoor(player.CurrentRoom.South);
                }
                else if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    player.UseDoor(player.CurrentRoom.West);
                }
                else if (keypress.Key == ConsoleKey.RightArrow)
                {
                    player.UseDoor(player.CurrentRoom.East);
                }
                else if (keypress.Key == ConsoleKey.E)
                {
                    player.CurrentRoom.Search();
                    //player.inventory.Add(player.CurrentRoom.ItemsList[0]);
                }
                else if (keypress.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            while (true);
        }
    }
}