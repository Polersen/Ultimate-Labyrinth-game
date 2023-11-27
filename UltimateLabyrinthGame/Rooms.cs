using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<items> Items { get; set; }
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

        public static void Search()
        {
            List<string> itemsList = new List<string>(); // TODO: Change to List<items>

            itemsList.Add("Key"); // Test
            itemsList.Add("Sword"); // Test

            for (int i = 0; i < itemsList.Count; i++)
            {
                Console.WriteLine(itemsList[i]);
            }
        }
    }
}
