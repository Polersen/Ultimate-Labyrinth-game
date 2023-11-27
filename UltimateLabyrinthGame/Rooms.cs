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
            ItemsList = new List<Items>();
        }
        public string Title { get { return title; } }
        public string Text { get { return text; } }
        public int North { get { return north; } set { north = value; } }
        public int East { get { return east; } set { east = value; } }
        public int South { get { return south; } set { south = value; } }
        public int West { get { return west; } set { west = value; } }
        public List<Items> ItemsList { get; set; }
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

        public Room AddItem(string itemID, string name, string desc, bool iskey, bool isweapon)
        {
            ItemsList.Add(new Items(itemID ,name, desc, iskey, isweapon));
            return this;
        }

        public void Search()
        {
            //List<Items> itemsList = new List<Items>();

            //itemsList.Add(new Items("Skull Key", "A key with an ingrained skull on it", true, false));
            //itemsList.Add(new Items("Cat Key", "A key with a cats face on it", true, false));
            //itemsList.Add(new Items("Rusty Key", "A rusty key in poor condition", true, false));
            //itemsList.Add(new Items("Golden Key", "A key made of pure gold", true, false));
            //itemsList.Add(new Items("Magic Key", "A key omitting a purple light", true, false));

            //itemsList.Add(new items("Glowing Sword", "A sword that emits a blue light", false, true)); // An example for a sword

            for (int i = 0; i < ItemsList.Count; i++)
            {
                Console.WriteLine($"{i+1}: {ItemsList[i].Name}");
            }
        }
    }
}
