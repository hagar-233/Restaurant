using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    public class Menu
    {
        public string name;
        public int price;
        public Menu(string n,int p) { 
        
        name = n;
         price = p;
        }
         
        public static List<Menu> MainDishes = new List<Menu>
        {
            new Menu("Classic Burger",55),
            new Menu("Chicken Burger",50),
            new Menu("Beef Pizza",85),
            new Menu("Margherita Pizza",75),
            new Menu("Chicken Shawarma",60),
            new Menu("Grilled Chicken",95),
            new Menu("Pasta Alfredo",70),
        };
        public static List<Menu> Appetizers = new List<Menu>
        {
            new Menu("French Fries",30),
            new Menu ("nion Rings",25),
            new Menu("Mozzarella Sticks",35),
            new Menu("Garlic Bread",20 ),
        };

        public static List<Menu> Drinks = new List<Menu>
        {
           new Menu("Cola",15),
           new Menu("Orange Juice",20),
           new Menu ("Water",10),
           new Menu ("Iced Coffee",25),
           };

        public static List<Menu> Deserts = new List<Menu>
        {
           new Menu("Chocolate Cake",40),
           new Menu("Cheesecake",45),
           new Menu("Ice Cream Scoop",20),
           new Menu("Waffles with Honey",50)

        };



    }
}
