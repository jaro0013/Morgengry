using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level { low, medium, high };
    public class Amulet
    {
        string ItemID { get; set; }
        string Design { get; set; }

        Level Quality { get; set; }



        
        public Amulet(string itemID):
            this(itemID, Level.medium, "")
        {
            //this.itemID = itemID;

        }

        public Amulet(string itemID, Level quality):
            this(itemID, quality, "")
        {
            //this.itemID = itemID;
            //this.quality = quality;
        
        }

        public Amulet (string itemID,Level quality,string design)
        {
            this.ItemID = itemID;
            this.Quality = quality;
            this.Design = design;
        }
        
        public string ToString()
        {
            return "ItemId: " + ItemID + ", " + "Quality: " + Quality + ", " + "Design: " + Design;
        }

    }
}
