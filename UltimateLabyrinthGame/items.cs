using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateLabyrinthGame
{
    public static class itemIDarray 
    {
        public static string[] itemIDarr = { "28074", "69393", "63458", "26183", "7620", "63205", "79133",
        "18267", "27435","77689"};

    }
    
    public class Items
    {
        public string itemID {  get; private set; }
        public string Name { get; set; }
        public string Desc {  get; set; }
        public bool isKey { get; private set; }
        public bool isWeapon { get; private set; }


        public Items(string ItemID, string name, string desc, bool iskey, bool isweapon)
        {
            this.itemID = ItemID;
            this.Name = name;
            this.Desc = desc;
            this.isKey = iskey;
            this.isWeapon = isweapon;
        }
    }
}