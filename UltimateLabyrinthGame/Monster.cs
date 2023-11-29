using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public class Monster
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Weakness { get; set; }

        public string SlainMessage = "You slay the monster with your weapon.";

        public Room Room;

        public Monster(string name, string desc, string weak)
        {
            this.Name = name;
            this.Description = desc;
            this.Weakness = weak;
        }

        public Items DropItem;

        public static List<Monster> AllMonstersList = new List<Monster>()
        {
            new Monster("Spaghetti Monster", "A flying ball of spaghetti is flailing its spaghetti-like arms at you!", "Fork"),
            new Monster("Fire Dragon", "A fire breathing dragon is snarling at you!", "Ice Sword"),
            new Monster("Ogre", "A stupid ogre is staring at you!", "Cat Dagger"),
            new Monster("Astrid", "A nimble cat with razor sharp claws slashing at you!", "Water"),
            new Monster("Goblin", "A small agitated little goblin is screaming at you to leave his precious alone!", "Light"),
            new Monster("Giant Spider", "An enormous spider is spinning web arount what looks like a corpse!", "Fire"),
            new Monster("Wraith", "A ghost-like creature is hovering slightly above the floor with a dagger in each hand!", "Electricity"),
            new Monster("Stone Golem", "A large human-like creature made of solid stone swinging its arms at you!", "Pickaxe")
        };

        // Körs när månstret attackeras
        public void OnAttacked() {
            Items item = Program.player.GetWeapon(Weakness);
            if(item != null) {
                // Beat monster
                OnSlain();
            } else {
                // Die, probably.
                Program.player.Die();
            }
        }

        // Körs när monstret slås
        public void OnSlain() {
            Console.Clear();
            Console.Write(Room.BasicRoomText());

            Console.WriteLine(SlainMessage);

            // Do item drop
            if (DropItem != null) {
                Items item = DropItem;
                Console.WriteLine($"The monster dropped an item: {item.Name}!");
                Program.player.inventory.Add(item);
            }

            // TODO: Remove from list.
            Room.MonsterList.Remove(this);

            if (Room.MonsterList.Count == 0) {
                Console.WriteLine("The room is now free from monsters.\n");
                Console.Write(Room.Directions);
                Console.WriteLine("E - Search the room\nI - Open inventory\n");
            } else {
                Console.WriteLine("\n" + Room.GetFrontMonster().ReturnMonsterFightText());
            }
        }

        public Monster SetDroppedItem(Items item) {
            DropItem = item;
            return this;
        }

        public string ReturnMonsterFightText() {
            string ret = "";

            ret += Name + ":\n";
            ret += Description + "\n";
            ret += "\n";
            ret += $"R - Run away from {Name}\n";
            // Do weapon check
            Items item = Program.player.GetWeapon(Weakness);
            if (item != null) {
                ret += $"T - Hit {Name} with your {item.Name}\n";
            } else {
                ret += $"T - Try to hit {Name}";
            }
            return ret;
        }
    }
}
