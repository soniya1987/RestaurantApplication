using System;
using System.Collections.Generic;

namespace RestaurantApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating all the menuitems
            MenuItem pasta = new MenuItem(10.00, "Pasta", "Main Course", true);
            MenuItem friedChicken = new MenuItem(7.50, "Fried Chicken", "Appetizer", true);
            MenuItem friedRice = new MenuItem(13.50, "Fried Rice", "Main Course", true);

            //adding the menuitems to the menu with timestamp
            Menu menu = new Menu(DateTime.Now, new List<MenuItem>() { pasta, friedChicken, friedRice });

            //creating an instance for restaurant and adding the menu
            Restaurant restaurant = new Restaurant("Pasta House", menu);
            //when restaurant.tostring() is invoked, menu.tostring() will be invoked and it will loop through the menu items and print them all
            Console.WriteLine(restaurant.ToString());
            Console.ReadLine();

            //deleting the pasta menuitem from the menu
            restaurant.Menu.DeleteMenuItem("pasta");

            //reprinting the restaurant with the updated menuitems
            Console.WriteLine(restaurant.ToString());
            Console.Read();
        }
    }
}
