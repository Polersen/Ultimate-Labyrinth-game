namespace UltimateLabyrinthGame
{
    public class Room
    {
        public static int NoDoor = -997;
        int self;
        string title;
        string text;
        int north, east, south, west;
        public Room(int self, string name, string text, int N, int E, int S, int W)
        {
            this.self = self; this.title = name; this.text = text;
            north = N; east = E; south = S; west = W;
        }
        public string Title { get { return title; } }
        public string Text { get { return text; } }
        public int North { get { return north; } set { north = value; } }
        public int East { get { return east; } set { east = value; } }
        public int South { get { return south; } set { south = value; } }
        public int West { get { return west; } set { west = value; } }
        public string Directions
        {
            get
            {
                string dir = "Det går dörrar till:\n";
                if (north != NoDoor) dir += "  w - norr\n";
                if (east != NoDoor) dir += "  d - öster\n";
                if (south != NoDoor) dir += "  s - söder\n";
                if (west != NoDoor) dir += "  a - väster\n";
                return dir;
            }
        }
    }
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
       

        static void Main(string[] args)
        {
            




        }
    }
}