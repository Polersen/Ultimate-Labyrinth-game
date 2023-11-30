namespace UltimateLabyrinthGame
{
     
    internal class Program
    {

        public static Player player;

        public static void Main(string[] args)
        {
            player = new Player();
            player.GoToRoom(UltimateLabyrinth.description[0]);

            MovementLoop();
        }

        public static bool IsRunning = true;

        public static void MovementLoop()
        {
            do
            {
                var keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.UpArrow || keypress.Key == ConsoleKey.W)
                {
                    player.UseDoor(player.CurrentRoom.North);
                }
                else if (keypress.Key == ConsoleKey.DownArrow || keypress.Key == ConsoleKey.S)
                {
                    player.UseDoor(player.CurrentRoom.South);
                }
                else if (keypress.Key == ConsoleKey.LeftArrow || keypress.Key == ConsoleKey.A)
                {
                    player.UseDoor(player.CurrentRoom.West);
                }
                else if (keypress.Key == ConsoleKey.RightArrow || keypress.Key == ConsoleKey.D)
                {
                    player.UseDoor(player.CurrentRoom.East);
                }
                else if (keypress.Key == ConsoleKey.E)
                {
                    if (player.CurrentRoom.GetFrontMonster() == null) {
                        player.CurrentRoom.Search();
                    }
                }
                else if (keypress.Key == ConsoleKey.I)
                {
                    PrintInventory();
                }
                else if (keypress.Key == ConsoleKey.R)
                {
                    if (player.CurrentRoom.GetFrontMonster() != null) {
                        Console.WriteLine("You run away.");
                        player.GoToRoom(UltimateLabyrinth.description[5]);
                        Console.WriteLine("You have just run back into this room.");
                    }
                }
                else if (keypress.Key == ConsoleKey.H)
                {
                    Help();
                }
                else if (keypress.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Goodbye!");
                    IsRunning = false;
                }else if (keypress.Key == ConsoleKey.T) {
                    // Try to fight
                    Monster monster = player.CurrentRoom.GetFrontMonster();
                    if (monster != null) {
                        monster.OnAttacked();
                    }
                }
            }
            while (IsRunning);

            static void PrintInventory()
            {
                if (player.inventory.Count != 0)
                {
                    Console.WriteLine("Inventory:");
                    foreach (var item in player.inventory)
                    {
                        if (item.isKey == true)
                        {
                            Console.WriteLine($"Item: {item.Name}   Description: {item.Desc}");
                        }
                        else if (item.isWeapon == true)
                        {
                            Console.WriteLine($"Item: {item.Name}   Description: {item.Desc}");
                        }
                    }
                }
                else Console.WriteLine("Your pockets are empty!");
            }

            static void Help()
            {
                Console.WriteLine("Keybindings:\n" +
                    "  W / Arrow forward - walk forward\n" +
                    "  S / Arrow down - walk back\n" +
                    "  D / Arrow right - walk right\n" +
                    "  A / Arrow left - walk left\n" +
                    "  E - Search\n" +
                    "  F - Use item \n" +
                    "  I - Open inventory\n" +
                    "  R - Run away\n" +
                    "  T - Try to fight\n" +
                    "  H - Help\n" +
                    "  Esc - End program\n");
            }
        }
    }
}