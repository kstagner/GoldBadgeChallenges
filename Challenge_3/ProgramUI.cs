using Challenge_3;
using System;
using System.Collections.Generic;

namespace Challenge_3

{
    public class ProgramUI
    {
        OutingsRepository _outingsRepo = new OutingsRepository();
        Queue<Outing> _outings = new Queue<Outing>();
        public void Run()
        {
            ShowStartMenu();

            bool running = true;
            {
                while (running)
                {
                    int choice = GetAndParseMenuChoice();

                    switch (choice)
                    {
                        case 1:
                            ViewOutingsList();
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
            }

        }

        public void Outing()
        {
            bool running = true;
            while (running) 
          
            Console.WriteLine($"Choose a menu item\n" +
                $"1 Display Outings List\n" +
                $"2 Add Outing\n" +
                $"3 Calculations");

            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);

     
            
        }

        private void ViewOutingsList()
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

            string eventtype = Console.ReadLine();
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
               $"2. Bowlingn\n" +
               $"3. Concert\n" +
               $"4. Golf");
        }

        private int GetAndParseMenuChoice()
        {
            Console.WriteLine("Please enter a number 1 - 4 here: ");
            int choice = Int32.Parse(Console.ReadLine());
            return choice; 
        }
    }



}

