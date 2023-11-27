using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame {
    internal class Doorway {

        // TODO: Uncomment this
        //public Room room;
        //public Room destination;
        public string KeyName = ""; // Empty means no key is required

        // Messages
        public string DoorDescription = "A regular door.";
        public string CantEnterMessage = "This door is locked, you dummy!";

        public Doorway() {
            // TODO: Set 'room' to this.
        }

        // TODO: Create constructor that takes destination room, descripton and denial message.

        public void Enter() {
            // TODO: Set player position to this room.
        }

        public bool CanEnter() {
            if (KeyName == "") return true;
            // TODO: Check inventory for key of right name.
            return false;
        }
    }
}
