using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morgengry
{
    class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
            
        }
        public IValuable GetValuable(string Id)
        {
            return valuables.Find(x => x.Id == id);
        }

        public double GetTotalValue()
        {
            double allValuables = 0;
            foreach (IValuable v in valuables)
            {
                allValuables = IValuable.GetValue(v);
            }

            return allValuables;
        }
    }
}
