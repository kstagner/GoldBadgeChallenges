using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public class OutingsRepository
    {
        Queue<Outing> _outings = new Queue<Outing>();

        public Queue<Outing> GetOutingsQueue()
        {
            return _outings;
        }
        public void AddNewOuting(Outing newOuting)
        { 
            _outings.Enqueue(newOuting);
        }
        public decimal CalculateCost(EventType type)
        {
            decimal totalCost = 68200m;
            switch (type)
            {
                case EventType.AmusementPark:
                    totalCost += 25200m;
                    break;
                case EventType.Bowling:
                    totalCost += 3500m;
                    break;
                case EventType.Concert:
                    totalCost += 27500m;
                    break;
                case EventType.Golf:
                    totalCost += 12000m;
                    break;
            }
            return totalCost;

        }



            


    }
}
