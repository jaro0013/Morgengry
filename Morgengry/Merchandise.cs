﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public abstract double GetValue();

        /*public Merchandise(string ItemId)
        {
            this.ItemId = ItemId;
        }

        public string ToString()
        {
            return "ItemId: " + ItemId;
        }*/
    }
}
