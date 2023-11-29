using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame {
    internal class Player {

        public bool hasKey(string id)
        {
            foreach(Items i in inventory)
            {
                if (i.isKey == true && i.itemID == id)
                {
                    return true;
                }
            }
            return false;
        }

        public Items GetWeapon(string id) {
            foreach(Items i in inventory) {
                if (i.isWeapon == true && i.itemID == id) return i;
            }
            return null;
        }

        public List<Items> inventory = new List<Items>();
        public Room CurrentRoom { get; set; }

        public void GoToRoom(Room room) {
            CurrentRoom = room;

            Console.Clear(); // Rensa skärmen
            string text = room.ReturnRoomText();
            Console.WriteLine(text);
        }

        public void UseDoor(Doorway door) {
            if (Program.player.CurrentRoom.GetFrontMonster() == null) {
                if (door != null) {
                    door.Enter();
                } else {
                    Console.WriteLine("You walked into the solid rock wall. Owie.");
                }
            }
        }

        public void Die() {
            Console.WriteLine("You died! Better luck next time.");
            Program.IsRunning = false;
        }
    }
}
