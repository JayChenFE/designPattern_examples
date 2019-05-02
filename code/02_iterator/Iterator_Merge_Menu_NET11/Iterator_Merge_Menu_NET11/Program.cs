using System;
using System.Collections;
using System.Linq;

namespace Iterator_Merge_Menu_NET11
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //使用.NET自带接口
            var breakfastMenu = new BreakfastMenu();
            var dinnerMenu = new DinnerMenu();

            Console.WriteLine("早餐:");
            foreach (MenuItem menuItem in breakfastMenu)
            {
                Print(menuItem);
            }

            Console.WriteLine("\n晚餐:");
            foreach (MenuItem menuItem in dinnerMenu)
            {
                Print(menuItem);
            }

            Console.ReadKey();
        }

        private static void Print(MenuItem menuItem)
        {
            Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}");
        }
    }
}
