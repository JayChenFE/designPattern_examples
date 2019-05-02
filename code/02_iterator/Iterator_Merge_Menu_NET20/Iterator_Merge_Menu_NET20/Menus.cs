using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Iterator_Merge_Menu_NET20
{
    public class BreakfastMenu : IEnumerable
    {
        private readonly ArrayList _menuItems;
        public BreakfastMenu()
        {
            _menuItems = new ArrayList();
            AddItem("牛奶", "牛奶description", false, 3.0);
            AddItem("油条", "油条description", false, 1.0);
            AddItem("馒头", "馒头description", true, 1.0);
            AddItem("豆浆", "豆浆description", true, 1.5);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(menuItem);
        }

        public IEnumerator GetEnumerator()
        {

            for (int i = 0; i < _menuItems.Count; i++)
            {
                yield return _menuItems[i];
            }
            
        }
    }

    public class DinnerMenu : IEnumerable
    {
        private const int MaxItems = 6;
        private int _numberOfItems = 0;
        private readonly MenuItem[] _menuItems;

        public DinnerMenu()
        {
            _menuItems = new MenuItem[MaxItems];
            AddItem("香菇豆腐饭", "香菇豆腐", false, 10.5);
            AddItem("蛋炒饭", "哈哈", false, 8.5);
            AddItem("鱼香肉丝", "你猜", true, 15.5);
        }

        private void AddItem(string name, string description, bool vegetarian, double price)
        {
            var menuItem = new MenuItem(name, description, vegetarian, price);

            if (_numberOfItems > MaxItems)
            {
                Console.WriteLine("菜单已满");
            }
            else
            {
                _menuItems[_numberOfItems++] = menuItem;
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _menuItems.Length; i++)
            {
                yield return _menuItems[i];
            }
        }
    }
}   
