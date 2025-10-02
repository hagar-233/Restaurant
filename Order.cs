using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    internal class Order
    {
       public string Nameitem;
       public int amount;
        public int price;   

       
        public static double totalprice( )
        {
            int total = 0;
            using (StreamReader f = new StreamReader(@"E:\items.txt"))
            {
               
                string line = f.ReadLine();
                while (line != null)
                {
                    string[]array= line.Split(',');
                    int priceitem=int.Parse(array[2]);
                    int amount=int.Parse(array[1]);
                     total += priceitem * amount;
                    line=f.ReadLine();
                }
            }
               
            return total;   
        }
        public static void AddItem(List<Order> listitem)
        {
            Order item = new Order();
            Console.Write("Enter number item:");
            int num = int.Parse(Console.ReadLine());
            while (num < 1 || num > 19)
            {
                Console.WriteLine("invalid number");
                num = int.Parse(Console.ReadLine());
            }
            
            if(num >= 1 && num <= 7)
            {
                item.Nameitem = Menu.MainDishes[num - 1].name;
                item.price = Menu.MainDishes[num - 1].price;


            }
            else if (num >= 8 && num <= 11)
            {
                item.Nameitem = Menu.Appetizers[num - 8].name;
                item.price = Menu.Appetizers[num - 8].price;

            }
            else if (num >= 12 && num <= 15)
            {
                item.Nameitem = Menu.Drinks[num - 12].name;
                item.price = Menu.Drinks[num - 12].price;
            }
            else if (num >= 16 && num <= 19)
            {
                item.Nameitem = Menu.Deserts[num -16].name;
                item.price = Menu.Deserts[num - 16].price;
            }
            Console.Write("Enter amount of item: ");
            int amountitem= int.Parse(Console.ReadLine());
            item.amount = amountitem;   
            listitem.Add(item); 
            Saveitem(listitem);
            

        }

        public static void Saveitem(List<Order> listitem)
        {
            using (StreamWriter f = new StreamWriter(@"E:\items.txt", false))
            {
                foreach (Order o in listitem)
                {
                    f.WriteLine($"{o.Nameitem},{o.amount},{o.price}");
                }
            }
        }
        public static bool ViewOrder(List<Order> listitem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("===========Your Order=====================");
            if (listitem.Count == 0)
            {
                Console.WriteLine("No Order to View");
                return false;
            }
            else
            {
                Console.WriteLine("{0,-20} {1,-10} {2,-15}", "Item Name", "Quantity", "Total Price");
                Console.WriteLine(new string('-', 43));
                foreach (Order o in listitem)
                {
                    double total=o.price* o.amount;
                    Console.WriteLine("{0,-20} {1,-10} {2,-15}", o.Nameitem , o.amount,total );
                   
                }
                return true;
            }
        }
        public static List<Order>  Loaditem()
        {
            List<Order> listitem = new List<Order>();
            if (File.Exists(@"E:\items.txt"))
            {
                string[] array = File.ReadAllLines(@"E:\items.txt");
                foreach (var i in array)
                {
                    var part = i.Split(',');
                    if (part.Length == 3) { 
                   
                        listitem.Add(new Order
                        {
                            Nameitem = part[0],
                            amount = int.Parse(part[1]),
                            price = int.Parse(part[2]),
                           
                        });


                    }
                }
            }
            return listitem;

        }
        public static void RemoveItem(List<Order> listitem)
        {
           
            if (!ViewOrder(listitem))
            {
                Console.WriteLine("No Order to View");
            }
            else
            {
                
                Console.Write("Enter number item to Reamove:");
                int Rem = int.Parse(Console.ReadLine());
                while (Rem < 1 || Rem > listitem.Count)
                {
                    Console.WriteLine("invalid number\n try again");
                    Console.Write("Enter number item to Reamove:");
                    Rem = int.Parse(Console.ReadLine());
                }
                listitem.Remove(listitem[Rem]);
              Order.Saveitem(listitem);
            }


        }
          
    }
}
