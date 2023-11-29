using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public class Monster
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Weakness { get; set; }

        public Room Room;

        public Monster(string name, string desc, string weak)
        {
            this.Name = name;
            this.Description = desc;
            this.Weakness = weak;
        }

        public Items DropItem;

        // Körs när månstret attackeras
        public void OnAttacked() {

        }

        // Körs när monstret slås
        public void OnSlain() {



            // Do item drop
            if (DropItem != null) {
                Items item = DropItem;
                Console.WriteLine($"The monster dropped an item: {item.Name}");
                Program.player.inventory.Add(item);
            }
        }
    }
}
