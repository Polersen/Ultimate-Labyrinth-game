using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public class UltimateLabyrinth
    {

        public static List<Room> description = new List<Room>()
        {
            new Room(0,"Entrance", "The Hole\n" +
                " You fell down a hole and find yourself\n" +
                " in a dark and damp room with only one door\n" +
                " that is leading down a dark hallway.\n" +
                " You need to find your way out!\n",
                N: new Doorway(1),
                E: null,
                S: null,
                W: null
                ),                      
            new Room(1, "The Labyrinth", "Dark Hallway\n" +
                " The darkness consumes your vision as\n" +
                " you push further into the hallway.\n" +
                " You start to see the outlines of an open doorway and\n" +
                " torches lining the walls beyond it.\n",
                N: new Doorway(5),
                E: null,
                S: new Doorway(0),
                W: null
                ),
            new Room(2,"The Labyrinth", "Scary Room\n" +
                " AAH! A monster lashes out at you when you enter!\n" +
                " It doesnt quite reach you. It seems to be chained\n" +
                " to the back wall, there is a chest in the corner.\n",
                N: null,                                                    
                E: null,
                S: new Doorway(6),
                W: null
                )
                .AddMonster(Monster.AllMonstersList[0])
                .AddItem("7","Cat Key","Key to door with cat.",true,false)
                .SetRoomItemsDescription("There is something that sticks out of the chest..\n", "The item you earlier found is now gone.\n"),
            new Room(3,"The Labyrinth", "The Armory\n" +
                " All along the walls are scraps of metal that\n" +
                " seem to have been armor, a few decades ago.\n" +
                " At the back of the room there is an armor stand with a weapon and a halfbroken chest.\n" +
                " The weapon is a little blunt but usable still.\n",         
                N: null,
                E: null,
                S: new Doorway(4),
                W: null
                )
                .AddItem("2", "Skull Key", "Key to room with skull on door", true, false)
                .AddItem("Giant fork", "Giant fork", "Fork made to make spin attack ", false, true)
                .SetRoomItemsDescription("There seems to be something next to the broken chest...\n", "The item you earlier found is now gone.\n"),
            new Room(4, "The Labyrinth", "The Bridge\n" +
                " The floor in this room is just a dark abyss aside from\n" +
                " the narrow stone pathway that is covered in wet moss.\n" +
                " But you see a door at the end of the pathway with a shield on it.\n" +
                " Watch your step so you dont fall...\n",
                N: null,
                E: new Doorway(3){KeyName = "3"},
                S: new Doorway(5),
                W: null
                ),
            new Room(5, "The Labyrinth", "The Crossroads\n" +
                " This room is brightly lit by torches\n" +
                " and has doors in every direction!\n" +
                " The door straight ahead has a symbol of a cat on it.\n",
                N: new Doorway(7){KeyName = "7"},
                E: new Doorway(4),
                S: new Doorway(1),
                W: new Doorway(6)
                ),
            new Room(6, "The Labyrinth", "The Library\n" +  
                " This room has a big grey stone door to the left,\n" +
                " there is a skull above the door that looks ominous.\n" +
                " Every other wall is all bookshelves, stacked\n" +
                " to the brim with books and junk.\n\n" +
                " Maybe there is something useful in this room...",
                N: null,
                E: null,
                S: new Doorway(5),
                W: new Doorway(2){KeyName = "2"}
                )
                .AddItem("3", "Shield Key", "Key to door with a shield.", true, false)
                .SetRoomItemsDescription("You see something crammed between two books...\n", "The item you earlier found is now gone.\n"),
            new Room(7, "The Labyrinth", "The Cat Room\n" +
                " The floor of this room is a shallow pit filled with angry kittens!\n" +
                " You have to step down into the pit to get across.\n" +
                " All the kittens attack your legs with their\n" +
                " claws as you're wading through!\n" +
                " There are doors to your left and right!\n",
                N: null,
                E: new Doorway(8),
                S: new Doorway(5),
                W: new Doorway(10)
                ),
            new Room(8, "The Labyrinth", "The Bright Hallway\n" +
                " The kittens in the last room really got you good...\n" + 
                " You look around and see a few portraits scattered about.\n" +
                " When you take a step, the eyes in the paintings\n" +
                " follow you as you move. There is a rusty steel door at the end of the room.\n" +
                " At the top of it is a tree, and you can see a faint\n" +
                " glimpse of light escaping underneath it.\n",
                N: null,
                E: new Doorway(9){KeyName = "9"},
                S: null,
                W: new Doorway(7)
                ),
            new Room(9, "The Labyrinth", "The End\n" +
                " Steps lead up into the warming light of the sun!\n" +
                " Free at last!\n",
                N: null,
                E: null,
                S: new Doorway(8),
                W: null
                ),
             new Room(10, "The Labyrinth", "The Nasty Room\n" +
                " This room.. is slimy, smelly and disgusting.\n" +
                " Every surface of this room made of fleshy material,\n" +
                " and worst of all, it is pulsating... Like its alive.\n",
                N: null,
                E: null,
                S: new Doorway(7),
                W: null
                )
                .AddItem("9", "Tree Key", "Key to door with tree.", true, false)
                .SetRoomItemsDescription("You think you see something glistening underneath some slime in a corner... You're gonna have to dig it out.\n", "The item you earlier found is now gone.\n")

        };
    }
}
