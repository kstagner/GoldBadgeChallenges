using Challenge_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Challenge_3

{
    public class ProgramUI
    {
        OutingsRepository _outingsRepo = new OutingsRepository();
        Queue<Outing> _outings = new Queue<Outing>();
        bool running = true;

        public void Run()
        {
            SeedList();

            while (running)
            {
                Console.Clear();
                Outing();
            }
        }

        private void SeedList()
        {
            Outing outing = new Outing(EventType.AmusementPark, 300, new DateTime(2018 / 21 / 07), 80, 25200);
            Outing outingTwo = new Outing(EventType.Bowling, 50, new DateTime(2018 / 04 / 12), 50, 12000);
            Outing outingThree = new Outing(EventType.Concert, 500, new DateTime(2018 / 24 / 06), 55, 27500);
            Outing outingFour = new Outing(EventType.Golf, 100, new DateTime(2018 / 24 / 06), 100, 12000);

            _outingsRepo.AddNewOuting(outing);
            _outingsRepo.AddNewOuting(outingTwo);
            _outingsRepo.AddNewOuting(outingThree);
            _outingsRepo.AddNewOuting(outingFour);
        }

        private void Outing()
        {
            Console.WriteLine($"Choose a menu item\n" +
                $"1 See all outings\n" +
                $"2 Add Outing\n" +
                $"3 Calculations");

            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

            switch (input)
            {
                case 1:
                    SeeAllOutings();
                    break;
                case 2:
                    AddNewOuting();
                    break;
                case 3:
                    Calculations();
                    break;
                case 4:
                    running = false;
                    break;
                default:

                    break;
            }
        }
        private void SeeAllOutings()
        {
            Queue<Outing> outing = _outingsRepo.GetOutingsQueue();

            foreach (Outing item in outing)
            {
                Console.WriteLine($"Event Type: {item.EventType}");
                Console.WriteLine($"Number of People Attended: {item.Attendence}");
                Console.WriteLine($"Event Date: {item.EventDate}");
                Console.WriteLine($"Cost Per Person: {item.CostPerPerson}");
                Console.WriteLine($"Total Cost: {item.TotalCost}");
            }
            Console.ReadKey();
        }

        public void AddNewOuting()
        {
            Console.Clear();

            Console.WriteLine("Enter event type here: \n" +
                "1. Amusement Park\n" +
                "2. Bowling\n" +
                "3. Concert\n" +
                "4. Golf\n");
            int input = int.Parse(Console.ReadLine());

            EventType type;
            switch (input)
            {
                default:
                case 1:
                    type = EventType.AmusementPark;
                    break;
                case 2:
                    type = EventType.Bowling;
                    break;
                case 3:
                    type = EventType.Concert;
                    break;
                case 4:
                    type = EventType.Golf;
                    break;
            }

            Console.WriteLine("Enter attendence here: ");
            string attendenceAsString = Console.ReadLine();
            int attendence = int.Parse(attendenceAsString);

            Console.WriteLine("Enter event date here: ");
            string eventDateAsString = Console.ReadLine();
            DateTime eventdate = DateTime.Parse(eventDateAsString);

            Console.WriteLine("Enter cost per person here: ");
            string costPerPersonAsString = Console.ReadLine();
            decimal costperperson = decimal.Parse(costPerPersonAsString);

            Console.WriteLine("Enter total event cost here: ");
            string totalCostAsString = Console.ReadLine();
            decimal totalcost = decimal.Parse(totalCostAsString);

            Outing outing = new Outing(type, attendence, eventdate, costperperson, totalcost);

            _outingsRepo.AddNewOuting(outing);
        }
        public void Calculations()
        {
            Console.Clear();

            Console.WriteLine("Annual Totals \n" +
                $"Amusement Park Outings: 10,000.00\n" +
                $"Bowling Outings: 3,500.00\n" +
                $"Concert Outings: 27,000.00\n" +
                $"Golf Outings: 12,000.00");

            Console.ReadKey();
        }

        private void ShowStartMenu()
        {
            Console.WriteLine("Enter number for event type here: \n" +
            $"1. Amusement Park\n" +
            $"2. Bowling\n" +
            $"3. Concert\n" +
            $"4. Golf");
        }

    }
}
    








