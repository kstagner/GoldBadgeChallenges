using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_3
{
    public enum EventType {Golf, Bowling, AmusementPark, Concert}

    public class Outing
    {
        public EventType EventType { get; set; }
        public int Attendence { get; set; }
        public DateTime EventDate { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }

        public Outing() { }

        public Outing (EventType eventType, int attendence, DateTime eventDate, decimal costPerPerson, decimal totalCost)
        {           
            EventType = eventType;
            Attendence = attendence;
            EventDate = eventDate;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost;
        }
        public Outing(int v, EventType eventType)
        {
            EventType = eventType;
        }
    }
}
