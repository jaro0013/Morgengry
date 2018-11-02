using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book : Merchandise
    {
        //string ItemID { get; set; }
        private string title;
        private double price;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public Book(string itemID):
            this(itemID, "", 0)
        {
            //this.itemID = itemID;
        }

        public Book(string itemID, string title):
            this(itemID, title, 0)
        {
            //this.itemID = itemID;
            //this.title = title;
        }

        public Book(string itemID, string title,double price)
        {
            ItemId = itemID;
            Title = title;
            Price = price;
        }

        public string ToString()
        {
            return "ItemId: " + ItemId + ", " + "Title: " + Title + ", " + "Price: " + Price;
        }

        public override double GetValue()
        {
            return Price;
        }
    }

    
}
