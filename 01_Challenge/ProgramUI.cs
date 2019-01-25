using System;
using System.Collections.Generic;

namespace _01_Challenge
{
    public class ProgramUI
    {
        private Manager _manager;
        private MenuRepository _menuRepo;

        public ProgramUI()
        {
            _manager = new Manager();
            _menuRepo = new MenuRepository();
        }
        public void Run()
        {
            bool running = true;
            while(running)
                Console.Clear();
            Console.WriteLine($"Komodo Cafe\n" +
                $"1. Add a menu item\n" +
                $"2. Remove a menu item\n" +
                $"3. Display menu items\n" +
                $"4. Exit application");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        AddMenuItem();
                        break;
                    case 2:
                        RemoveMenuItem();
                        break;
                    case 3:
                        DisplayMenuItems();
                        break;
                    case 4:
                        running = false;
                        break;
                    
                }
        }

        

        public void AddMenuItem()
        {
            Console.WriteLine("Enter meal number here");
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);

            Console.WriteLine("Enter meal name here");
            string name = Console.ReadLine();

            Console.WriteLine("Enter meal description here");
            string description = Console.ReadLine();

            Console.WriteLine("Enter meal ingredients here");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Enter cost of meal here");
            string costAsString = Console.ReadLine();
            decimal cost = decimal.Parse(costAsString);


            Menu newMenu = new Menu(number, name, description, ingredients, cost);
            _menuRepo.AddMenuItem(newMenu);
        }

        public void RemoveMenuItem()
        {
            Console.WriteLine("Enter meal number here");
            string numberAsString = Console.ReadLine();
            int number = int.Parse(numberAsString);

            Console.WriteLine("Enter meal name here");
            string name = Console.ReadLine();

            Console.WriteLine("Enter meal description here");
            string description = Console.ReadLine();

            Console.WriteLine("Enter meal ingredients here");
            string ingredients = Console.ReadLine();

            Console.WriteLine("Enter cost of meal here");
            string costAsString = Console.ReadLine();
            decimal cost = decimal.Parse(costAsString);

            Menu newMenu = new Menu(number, name, description, ingredients, cost);
            _menuRepo.RemoveMenuItem(newMenu);
        }

        public void DisplayMenuItems()
        {
            List<Menu> menu = _menuRepo.GetMenuList();

            foreach (Menu item in menu)
            {
                Console.WriteLine($"Meal Number: {item.MealNumber}");
                Console.WriteLine($"Meal Name: {item.MealName}");
                Console.WriteLine($"Description: {item.MealDescription}");
                Console.WriteLine($"Ingredients: {item.MealIngredients}");
                Console.WriteLine($"Cost: {item.MealCost}");
            }
            Console.ReadKey();
        }
    }   
}