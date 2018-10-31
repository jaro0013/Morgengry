using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new List<Merchandise>();
        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
            merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            return merchandises.Find(x => x.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double allMerchandises = 0;
            foreach (Merchandise m in merchandises)
            {
                allMerchandises = Utility.GetValueOfMerchandise(m);
            }

            return allMerchandises;
        }
    }
}
