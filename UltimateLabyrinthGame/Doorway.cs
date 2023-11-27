using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame {
    internal class Doorway {

        public Room room;
        public Room destination;
        public string KeyName = ""; // Empty means no key is required

        // Messages
        public string DoorDescription = "A regular door.";
        public string CantEnterMessage = "This door is locked, you dummy!";

        public Doorway(Room room, Room destination) {
            this.room = room;
            this.destination = destination;
        }
        public Doorway(Room room, Room destination, string description, string cantentermessage) {
            this.room = room;
            this.destination = destination;
            DoorDescription = description;
            CantEnterMessage = cantentermessage;
        }
        public Doorway(Room room, Room destination, string description, string cantentermessage, string keyname) {
            this.room = room;
            this.destination = destination;
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
            // TODO: Check inventory for key of right name.
            return false;
        }
    }
}
