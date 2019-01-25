using System;
using System.Collections.Generic;
using System.Linq;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuRepository_Tests
    {
        [TestMethod]
        public void MenuRepository_AddMenuItem_ShouldBeCorrectCount()
        {
            //Arrange
            MenuRepository _menuRepo = new MenuRepository();
            Menu menu = new Menu();
            Menu menuTwo = new Menu();
            Menu menuThree = new Menu();

            _menuRepo.AddMenuItem(menu);
            _menuRepo.AddMenuItem(menuTwo);
            _menuRepo.AddMenuItem(menuThree);

            //Act
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 3;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_RemoveMenuItem_ShouldBeCorrectCount()
        {
            //Arrange
            MenuRepository _menuRepo = new MenuRepository();
            Menu menu = new Menu();
            Menu menuTwo = new Menu();
            Menu menuThree = new Menu();

            _menuRepo.AddMenuItem(menu);
            _menuRepo.AddMenuItem(menuTwo);
            _menuRepo.AddMenuItem(menuThree);

            _menuRepo.RemoveMenuItem(menu);

            //Act
            int actual = _menuRepo.GetMenuList().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);       
        }
    }
}
