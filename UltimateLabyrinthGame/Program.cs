namespace UltimateLabyrinthGame
{


    public class UltimateLabyrinth
    {
        static Room help = new Room(-1, "Help",  // Rename what buttons to press.
              "Följande kommandon finns:\n" +
              "  w - gå genom dörren norrut\n" +
              "  s - gå genom dörren söderut\n" +
              "  d - gå genom dörren österut\n" +
              "  a - gå genom dörren västerut\n" +
              "  l - leta\n" +
              "  h - hjälp\n" +
              "  z - avsluta\n",
              Room.NoDoor, Room.NoDoor, Room.NoDoor, Room.NoDoor);

        static List<Room> description = new List<Room>()
        {
            new Room(0,"Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(1, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:2, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(2,"Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(3,"Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(4, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(5, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(6, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(7, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(8, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),
            new Room(9, "Start", "Titel på rummet\n" +
                "Lägg till beskrivning på rum.",
                N:1, E:Room.NoDoor, S:Room.NoDoor, W:Room.NoDoor),


        };
    }

    internal class Program
    {

        public static void Main(string[] args)
        {

            List<items> inventory = new List<items>();
            MovementLoop();
        }

        public static void MovementLoop()
        {
            do
            {
                var keypress = Console.ReadKey();
                if (keypress.Key == ConsoleKey.UpArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå upp");
                }
                else if (keypress.Key == ConsoleKey.DownArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå ner");
                }
                else if (keypress.Key == ConsoleKey.LeftArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå Vänster");
                }
                else if (keypress.Key == ConsoleKey.RightArrow)
                {
                    //TODO: implementera rörelsefunktion
                    Console.WriteLine("Gå höger");
                }
                else if (keypress.Key == ConsoleKey.E)
                {
                    //TODO: implementera sökfunktion
                    Console.WriteLine("Leta");
                    Room.Search();
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