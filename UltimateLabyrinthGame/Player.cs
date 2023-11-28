﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame {
    internal class Player {

        public Room CurrentRoom { get; set; }

        public void GoToRoom(Room room) {
            CurrentRoom = room;
            // TODO: Ersätt raden under med ruminformation
            Console.WriteLine($"Du gick in i rum {room.ID}.");
            Console.WriteLine(room.Directions);
        }

        public void UseDoor(Doorway door) {
            if (door != null) {
                door.Enter();
            } else {
                Console.WriteLine("You walked into the solid rock wall. Owie.");
            }
        }
    }
}