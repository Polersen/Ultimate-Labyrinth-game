using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    internal class Monster
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Weakness { get; set; }

        public Monster(string name, string desc, string weak)
        {
            this.Name = name;
            this.Description = desc;
            this.Weakness = weak;
        }
    }
}
