using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame {
    internal class Doorway {

        public Room destination;
        public string KeyName = ""; // Empty means no key is required

        // Messages
        public string DoorDescription = "A regular door.";
        public string CantEnterMessage = "This door is locked, you dummy!";

        public Doorway(Room destination) {
            this.destination = destination;
        }

        public Doorway(Room destination, string description) {
            this.destination = destination;
            DoorDescription = description;
        }

        public Doorway(int destination_index, string description) {
            destination = GetRoomFromId(destination_index);
            DoorDescription = description;
        }

        public Doorway(Room destination, string description, string cantentermessage, string keyname) {
            this.destination = destination;
            DoorDescription = description;
            CantEnterMessage = cantentermessage;
            KeyName = keyname;
        }

        public Doorway(int destination_index, string description, string cantentermessage, string keyname) {
            destination = GetRoomFromId(destination_index);
            DoorDescription = description;
            CantEnterMessage = cantentermessage;
            KeyName = keyname;
        }

        public void Enter() {
            if (CanEnter()) {
                // TODO: Set player position to this room.
                Console.WriteLine("TODO");
            } else {
                Console.WriteLine(CantEnterMessage);
            }
        }

        public bool CanEnter() {
            if (KeyName == "") return true;
            // TODO: Check inventory for key of right item ID.
            return false;
        }

        /// <summary>
        /// Returns a Room from id.
        /// </summary>
        /// <param name="id">The index "self".</param>
        /// <returns></returns>
        private static Room GetRoomFromId(int id) {
            Room room = UltimateLabyrinth.description.Where(r => r.ID == id).First();
            return room; // TODO: Returnera Room från listan i UltimateLabyrinth beroende på dess ID.
        }
    }
}
