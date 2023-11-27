using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public class Items
    {
        public string Name { get; set; }
        public string Desc {  get; set; }
        public bool isKey { get; private set; }
        public bool isWeapon { get; private set; }

        public Items(string name, string desc, bool iskey, bool isweapon)
        {
            this.Name = name;
            this.Desc = desc;
            this.isKey = iskey;
            this.isWeapon = isweapon;
        }
    }
}