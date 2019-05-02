using System;

namespace Iterator_Merge_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            ////不使用迭代器
            //var breakfastMenu = new BreakfastMenu();
            //ArrayList breakfastItems = breakfastMenu.GetMenuItems();

            //var dinnerMenu = new DinnerMenu();
            //MenuItem[] dinnerItems = dinnerMenu.GetMenuItems();


            //foreach (var breakfastItem in breakfastItems)
            //{
            //    if (breakfastItem is MenuItem menuItem)
            //    {
            //        Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}");
            //    }
            //}

            //foreach (var dinnerItem in dinnerItems)
            //{
            //    if (dinnerItem != null)
            //    {
            //        Console.WriteLine($"{dinnerItem.Name} {dinnerItem.Price} {dinnerItem.Description}");
            //    }
            //}

            //使用迭代器
            var breakfastMenu = new BreakfastMenu();
            var dinnerMenu = new DinnerMenu();

            var dinnerIterator = dinnerMenu.CreateIterator();
            var breakfastIterator = breakfastMenu.CreateIterator();

            Console.WriteLine("早餐:");
            Print(breakfastIterator);
            Console.WriteLine();
            Console.WriteLine("晚餐:");
            Print(dinnerIterator);

            Console.ReadKey();

        }

        static void Print(ITerator iterator)
        {
            while (iterator.HasNext())
            {
                var menuItem = (MenuItem)iterator.Next();
                Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}");
            }
        }
    }
}
