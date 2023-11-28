using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public class Room
    {
        int self;
        string title;
        string text;
        Doorway north, east, south, west;
        public Room(int self, string name, string text, Doorway N, Doorway E, Doorway S, Doorway W)
        {
            this.self = self; this.title = name; this.text = text;
            north = N; east = E; south = S; west = W;
            ItemsList = new List<Items>();
        }
        public string Title { get { return title; } }
        public string Text { get { return text; } }
        public Doorway North { get { return north; } set { north = value; } }
        public Doorway East { get { return east; } set { east = value; } }
        public Doorway South { get { return south; } set { south = value; } }
        public Doorway West { get { return west; } set { west = value; } }
        public int ID { get { return self; } set { self = value; } }
        public List<Items> ItemsList { get; set; }
        public string Directions
        {
            get
            {
                string dir = "There are doors to your:\n";
                if(north != null) dir += "  Front - North\n";
                if (east != null) dir += "  Right - East\n";
                if (south != null) dir += "  Back - South\n";
                if (west != null) dir += "  Left - West\n";
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
            var keypress = Console.ReadKey(true);
            for (int i = 0; i < ItemsList.Count; i++)
            {
                Console.WriteLine($"{i}: {ItemsList[i].Name}");

                if (keypress.Key == ConsoleKey.NumPad0+i)
                {
                    Console.WriteLine($"You picked up {ItemsList[i].Name}");
                    PickUp(i);
                }
            }
        }

        public void PickUp(int i)
        {
            Player player = new Player();

            player.inventory.Add(ItemsList[i]);

            ItemsList.RemoveAt(i);
        }
    }
}
