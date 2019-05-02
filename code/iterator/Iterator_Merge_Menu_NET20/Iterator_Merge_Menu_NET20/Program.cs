using System;

namespace Iterator_Merge_Menu_NET20
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用yield return
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
                if (menuItem == null)
                {
                    continue;
                }

                Print(menuItem);
            }

            Console.ReadKey();


        }

        static void Print(MenuItem menuItem)
        {
            Console.WriteLine($"{menuItem.Name} {menuItem.Price} {menuItem.Description}");
        }
    }
}
