namespace UltimateLabyrinthGame
{


    

    internal class Program
    {

        public static Player player;

        public static void Main(string[] args)
        {
            player = new Player();
            player.GoToRoom(UltimateLabyrinth.description[0]);

            player.inventory.Add(new Items("1", "nyckel", "det är en ful nyckel", true, false));
            player.inventory.Add(new Items("2", "Sword", "Big ass sword", false, true));

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
                else if (keypress.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
            while (true);
        }
    }
}