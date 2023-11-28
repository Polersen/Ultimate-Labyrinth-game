namespace UltimateLabyrinthGame
{


    

    internal class Program
    {

        public static Player player;

        public static void Main(string[] args)
        {
            player = new Player();
            player.GoToRoom(UltimateLabyrinth.description[0]);

            player.inventory.Add(new Items("2", "Sword", "Big ass sword", false, true));
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
                    //TODO: implementera sökfunktion
                    Console.WriteLine("Search");
                    //Room.Search();
                }
                else if (keypress.Key == ConsoleKey.I)
                {
                    PrintInventory();
                }
                else if (keypress.Key == ConsoleKey.H)
                {
                    Help();
                }
                else if (keypress.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            while (true);

            static void PrintInventory()
            {
                Console.WriteLine("Inventory:");
                foreach (var item in player.inventory)
                {
                    if (item.isKey == true)
                    {
                        Console.WriteLine($"Item: {item.Name}   Description: {item.Desc}    Type: Key");
                    }
                    else if (item.isWeapon == true)
                    {
                        Console.WriteLine($"Item: {item.Name}   Description: {item.Desc}    Type: Weapon");
                    }
                }
            }

            static void Help()
            {
                Console.WriteLine("Keybindings:\n" +
                    "  Arrow forward - walk forward\n" +
                    "  Arrow down - walk back\n" +
                    "  Arrow right - walk right\n" +
                    "  Arrow left - walk left\n" +
                    "  E - Search\n" +
                    "  F - Use item \n" +
                    "  I - Open inventory\n" +
                    "  R - Run away\n" +
                    "  T - Try to fight\n" +
                    "  G - Glare\n" +
                    "  H - Help\n" +
                    "  Esc - End program\n");
            }
        }
    }
}