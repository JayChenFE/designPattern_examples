using System;

namespace Iterator_Merge_Menu_NET20
{
    public class MenuItem
    {
        public MenuItem(string name, string description, bool vegetarin, double price)
        {
            Name = name;
            Description = description;
            IsVegetarian = vegetarin;
            Price = price;
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 是否素食
        /// </summary>
        public bool IsVegetarian { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
    }
}
