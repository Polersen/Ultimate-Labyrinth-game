using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public class UltimateLabyrinth
    {

        public static Room help = new Room(-1, "Help",
              "Keybindings:\n" +
              "  Arrow forward - walk forward\n" +
              "  Arrow down - walk back\n" +
              "  Arrow right - walk right\n" +
              "  Arrow left - walk left\n" +
              "  e - Search\n" +
              "  f - Use item \n" +
              "  h - Help\n" +
              "  Esc - End program\n",
              null, null, null, null);

        public static List<Room> description = new List<Room>()
        {
            new Room(0,"Start", "Title on room\n" +
                "Add description of room.",
                N: new Doorway(1),
                E: null,
                S: null,
                W: null
                )
            .AddItem("skullkeyid", "Skull Key", "A key with an ingrained skull on it", true, false), // Key needs correct id from itemIdArray?
            new Room(1, "Start", "Title on room\n" +
                "Add description of room.",
                N: new Doorway(5),
                E: null,
                S: new Doorway(0),
                W: null
                ),
            new Room(2,"Start", "Title on room\n" +  // Add monster in this room
                "Add description of room.",         // Add key in this room (Opens door to 7.)
                N: null,                            // Add chest in this room (Ooooh gold or whatever!)
                E: null,
                S: new Doorway(6),
                W: null
                ),
            new Room(3,"Start", "Title on room\n" +  // Add key in this room (Opens door to 2.)
                "Add description of room.",         // Add sword in this room.
                N: null,
                E: null,
                S: new Doorway(4),
                W: null
                ),
            new Room(4, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: new Doorway(3),
                W: new Doorway(5)
                ),
            new Room(5, "Start", "Title on room\n" +
                "Add description of room.",
                N: new Doorway(7),
                E: new Doorway(4),
                S: new Doorway(1),
                W: new Doorway(6)
                ),
            new Room(6, "Start", "Title on room\n" +  // Add key in this room (Opens door to 4.)
                "Add description of room.",
                N: null,
                E: new Doorway(5),
                S: new Doorway(2),
                W: null
                ),
            new Room(7, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: new Doorway(8),
                S: new Doorway(5),
                W: new Doorway(10)
                ),
            new Room(8, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: new Doorway(9),
                S: null,
                W: new Doorway(7)
                ),
            new Room(9, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: new Doorway(8)
                ),
             new Room(10, "Start", "Title on room\n" +  // Add key in this room (Opens door to 9)
                "Add description of room.",
                N: null,
                E: new Doorway(7),
                S: null,
                W: null
                ),



        };
    }
}
