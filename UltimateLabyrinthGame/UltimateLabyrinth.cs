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
                N: new Doorway(1){KeyName = "1"},
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
            new Room(2,"Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(3,"Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(4, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(5, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(6, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(7, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(8, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),
            new Room(9, "Start", "Title on room\n" +
                "Add description of room.",
                N: null,
                E: null,
                S: null,
                W: null
                ),



        };
    }
}
