using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApplication
{
    public class MenuItem
    {
        public string Description { get; set; }
        //we declared it as a float since there will be decimals
        public double Price { get; set; }

        public string Category { get; set; }

        public bool IsNew { get; set; }

        public MenuItem(string description)
        {
            this.Description = description;
        }

        public MenuItem(double price, string description, string category, bool isNew): this(description)
        {
            this.Price = price;
            this.Category = category;
            this.IsNew = isNew;
        }

        /// <summary>
        /// This method will print the menuitem in a user friendly manner
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Menu Description : " + Description + ", Category : " + Category + ", Price : " + Price + ", IsNew : " + IsNew;
        }

        /// <summary>
        /// This method will compare the 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            MenuItem menuItem = obj as MenuItem;
            return Description.ToLower() == menuItem.Description.ToLower();
        }
    }
}
