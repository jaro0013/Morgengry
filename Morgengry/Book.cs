using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class Book
    {
        string ItemID { get; set; }
        string Title { get; set; }
        double Price { get; set; }

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
            this.ItemID = itemID;
            this.Title = title;
            this.Price = price;
        }

        public string ToString()
        {
            return "ItemId: " + ItemID + ", " + "Title: " + Title + ", " + "Price: " + Price;
        }

    }

    
}
