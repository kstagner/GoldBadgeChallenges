using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepository
    {
        private List<Menu> _menuList = new List<Menu>();

        public void AddMenuItem(Menu newMenu)
        {
            _menuList.Add(newMenu);
        }
        public void RemoveMenuItem(Menu newMenu)
        {
            _menuList.Remove(newMenu);
        }
        public List<Menu> GetMenuList()
        {
            return _menuList;
        }
    }
}
