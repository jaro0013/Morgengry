﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet GetAmulet (string itemId)
        {
            return amulets.Find(x => x.ItemId == itemId);
        }

        public Level GetTotalValue()
        {
            Level allAmulets = 0;
            foreach (Amulet a in amulets)
            {
               // allAmulets += a.Quality;
            }

            return allAmulets;

        }

          
        
    }
}