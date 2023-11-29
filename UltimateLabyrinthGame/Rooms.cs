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

        public string ItemFoundText = "";
        public string ItemNotFoundText = "";

        public Room AddItem(string itemID, string name, string desc, bool iskey, bool isweapon)
        {
            ItemsList.Add(new Items(itemID ,name, desc, iskey, isweapon));
            return this;
        }

        public void Search()
        {
            string pickUpmsg = "";
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Press Q to go back\n");

                for (int i = 0; i < ItemsList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {ItemsList[i].Name}");
                }

                Console.WriteLine(pickUpmsg);

                if (ItemsList.Count == 0)
                    Console.WriteLine("There are no more items here.");

                var keypress = Console.ReadKey(true);
                for (int i = 0; i < ItemsList.Count; i++)
                {
                    if (keypress.Key == ConsoleKey.D1 + i)
                    {
                        pickUpmsg = $"You picked up {ItemsList[i].Name}";
                        PickUp(i);
                    }
                }

                if (keypress.Key == ConsoleKey.Q)
                    break;
            }
            Console.Clear(); // Rensa skärmen
            string text = Program.player.CurrentRoom.ReturnRoomText();
            Console.WriteLine(text);
        }

        public void PickUp(int i)
        {
            Program.player.inventory.Add(ItemsList[i]);
            ItemsList.RemoveAt(i);
        }

        public string ReturnRoomText() {
            
            Monster monster = GetFrontMonster();
            string ret = BasicRoomText();
            
            if(monster == null) {
                ret += $"{Directions}";
                ret += "E - Search the room\n";
                ret += "I - Open inventory\n";
            } else {
                ret += monster.ReturnMonsterFightText();
            }
            return ret;
        }

        public string BasicRoomText() { // Rätt så lat kod egentligen
            string ret = $"{title}:\n" +
                $"{text}\n";
            if (ItemsList.Count > 0) {
                if (ItemFoundText != "") {
                    ret += ItemFoundText + "\n";
                }
            } else {
                if (ItemNotFoundText != "") {
                    ret += ItemNotFoundText + "\n";
                }
            }
            return ret;
        }

        public Room SetRoomItemsDescription(string _ItemFoundText, string _ItemNotFoundText) {
            ItemFoundText = _ItemFoundText;
            ItemNotFoundText = _ItemNotFoundText;
            return this;
        }

        public List<Monster> MonsterList = new List<Monster>();

        public Room AddMonster(Monster monster) {
            MonsterList.Add(monster);
            monster.Room = this;
            return this;
        }

        public Monster GetFrontMonster() {
            if (MonsterList.Count == 0) return null;
            return MonsterList[0];
        }
    }
}
