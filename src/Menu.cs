using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class Menu
    {
        public DateTime LastUpdated { get; set; }
        public List<MenuItem> MenuItems { get; set; }

        public Menu(DateTime lastUpdated, List<MenuItem> menuItems)
        {
            LastUpdated = lastUpdated;
            MenuItems = menuItems;
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            //If menuItems is null initiliaze the list with new key word
            if (MenuItems == null)
            {
                MenuItems = new List<MenuItem>();
            }
            //once the list is initialized add the menuItem to the list
            MenuItems.Add(menuItem);
            //anytime a menuItem is added then update the lastUpdated value with the latest timestamp
            this.LastUpdated = DateTime.Now;
        }

        /// <summary>
        /// This method will delete a menuitem based on the description
        /// </summary>
        /// <param name="description"></param>
        /// <returns>returns true if delete is successful</returns>
        public bool DeleteMenuItem(string description)
        {
            //use the above menuItem and delete the selected menu Item
            bool isDeleted = MenuItems.Remove(new MenuItem(description));
            if (isDeleted)
            {
                this.LastUpdated = DateTime.Now;
            }
            return isDeleted;
        }

        public override string ToString()
        {
            //create an empty string
            string menuItems = "";
            //keep appending the menuItem.tostring() value which will append the menuItem as a user friendly string
            foreach (MenuItem menuItem in MenuItems)
            {
                menuItems += menuItem.ToString() + "\n";
            }
            //return the concatenated menuItems 
            return menuItems + "\nLastUpdated : " + LastUpdated + "\n";
        }
    }
}
