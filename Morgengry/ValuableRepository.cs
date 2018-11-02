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
            IValuable fundet = null;


            return fundet;
        }

        public double GetTotalValue()
        {
            double allValuables = 0;
            foreach (IValuable v in valuables)
            {
                allValuables = allValuables + v.GetValue();
            }

            return allValuables;
        }

        public int Count()
        {
            return valuables.Count;
        }

         
    }
}
