using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamFormsCustomViews.MockData
{
    public class LunchMenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }

        public static List<string> GetCategories()
        {
            return new List<string>()
            {
                "Entree",
                "Veggie",
                "Fruit",
                "Beverage",
                "Carb",
                "Desert"
            };
        }

        public static List<LunchMenuItem> GetAllMenuItems()
        {
            List<LunchMenuItem> result = new List<LunchMenuItem>()
            {
                new LunchMenuItem() { Name = "Parm. Chicken", Category = "Entree", Price = 14.92},
                new LunchMenuItem() { Name = "Veal", Category = "Entree", Price = 23.23},
                new LunchMenuItem() { Name = "Mac and Cheese", Category = "Entree", Price = 8.24 },
                new LunchMenuItem() { Name = "Irish Stew", Category = "Entree", Price = 11.93},
                new LunchMenuItem() { Name = "Pea Pods", Category = "Veggie", Price = 1.92 },
                new LunchMenuItem() { Name = "Carrots", Category = "Veggie", Price = 2.03},
                new LunchMenuItem() { Name = "Potato", Category = "Veggie", Price = 1.52 },
                new LunchMenuItem() { Name = "Spinich", Category = "Veggie", Price =.92 },
                new LunchMenuItem() { Name = "Strawberries", Category = "Fruit", Price = 2.13 },
                new LunchMenuItem() { Name = "Grapes", Category = "Fruit", Price = 5.3 },
                new LunchMenuItem() { Name = "Coke", Category = "Beverage", Price = 1.00 },
                new LunchMenuItem() { Name = "Diet Coke", Category = "Beverage", Price = 1.00 },
                new LunchMenuItem() { Name = "Ice Tea", Category = "Beverage", Price = 1.23 },
                new LunchMenuItem() { Name = "Apple Juice", Category = "Beverage", Price = .97  },
                new LunchMenuItem() { Name = "Rice", Category = "Carb", Price =  1.32 },
                new LunchMenuItem() { Name = "Popover", Category = "Carb", Price = 2.91  },
                new LunchMenuItem() { Name = "Choc. Cate", Category = "Desert", Price = 4.94  },
                new LunchMenuItem() { Name = "Cookie", Category = "Desert", Price = 1.72  },
            };
    
            return result;
        }
    }
}
