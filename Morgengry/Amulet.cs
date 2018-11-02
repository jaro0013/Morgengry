using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public enum Level { low, medium, high };
    public class Amulet : Merchandise
    {
        
        //string ItemID { get; set; }
        private string design;
        private Level quality;
        private double lowQualityValue;
        private double mediumQualityValue;
        private double highQualityValue;

        public string Design
        {
            get { return design; }
            set { design = value; }
        }

        public Level Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        public double LowQualityValue
        {
            get { return lowQualityValue; }
            set { lowQualityValue = value; }
        }

        public double MediumQualityValue
        {
            get { return mediumQualityValue; }
            set { mediumQualityValue = value; }
        }

        public double HighQualityValue
        {
            get { return highQualityValue; }
            set { highQualityValue = value; }
        }
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

        public Amulet(string itemID,Level quality,string design):base(itemID)
        {
            ItemId = itemID;
            Quality = quality;
            Design = design;
        }
        
        public string ToString()
        {
            return "ItemId: " + ItemId + ", " + "Quality: " + Quality + ", " + "Design: " + Design;
        }

    }
}
