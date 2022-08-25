using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class Restaurant
    {
        public string Name { get; set; }

        public Menu Menu { get; set; }

        public Restaurant(string name, Menu menu)
        {
            Name = name;
            Menu = menu;
        }

        public override string ToString()
        {
            return "Restaurant Name : " + Name + "\n" + "Menu Items : \n" + Menu.ToString();
        }
    }
}
