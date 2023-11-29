using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame {
    public class Doorway {

        public int Destination;
        public string KeyName = ""; // Empty means no key is required

        // Messages
        public string DoorDescription = "A regular door.";
        public string CantEnterMessage = "This door is locked, you dummy!";

        public Doorway(int destination_index) {
            Destination = destination_index;
        }

        public Doorway(int destination_index, string description) {
            Destination = destination_index;
            DoorDescription = description;
        }

        public Doorway(int destination_index, string description, string cantentermessage, string keyname) {
            Destination = destination_index;
            DoorDescription = description;
            CantEnterMessage = cantentermessage;
            KeyName = keyname;
        }

        public void Enter() {
            if (CanEnter()) {
                Room room = GetRoomFromId(Destination);
                Program.player.GoToRoom(room);
            } else {
                Console.WriteLine(CantEnterMessage);
            }
        }

        public bool CanEnter() {
            if (KeyName == "") return true;
            /*foreach (Items i in Program.player.inventory)
            {
                if (i.itemID == KeyName) return true;
            }
            return false;*/
            return Program.player.hasKey(KeyName);
        }

        /// <summary>
        /// Returns a Room from id.
        /// </summary>
        /// <param name="id">The index "self".</param>
        /// <returns></returns>
        public static Room GetRoomFromId(int id)
        {
            Room room = UltimateLabyrinth.description.Where(r => r.ID == id).First();
            return room; // TODO: Returnera Room från listan i UltimateLabyrinth beroende på dess ID.
        }
    }
}
