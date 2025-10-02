using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Order.Loaditem();
            List<Customer> list = new List<Customer>();
            List<Order> listitem = new List<Order>();
           
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t\t\t\t*************");
            Console.WriteLine("\t\t\t\t\t\t Restaurant ");
            Console.WriteLine("\t\t\t\t\t\t*************");
           while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                int index = -1;
                Console.WriteLine("1.Creatnew account\n2.login\n3.Exit");
                Console.Write("Enter Your Choice:");
                string choice=Console.ReadLine();
                int value;
                while(!int.TryParse(choice, out  value) || value < 1 || value > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("invalid choice \n try again ");
                    choice = Console.ReadLine();
                }
                if (value == 1)
                {
                    
                   index= Customer.AddAcccount(list);
                    

                }
                else if (value == 2)
                {
                  List<Customer>customers=Customer.LoadData();
                    index =Customer.login(customers);
                    if (index == -1)
                        continue;
                }
                else if (value == 3)
                {
                    Console.ForegroundColor= ConsoleColor.Gray;
                    Console.WriteLine("Exit.....");
                    break;
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("1.view Menu\n2.view Order\n3.Payment\n4.update Profile\n5.Exit");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("Enter number choice:");
                     choice = Console.ReadLine();
                    int num;
                    while (!int.TryParse(choice, out num) || num < 1 || num > 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("invalid choice \n try again ");
                        choice = Console.ReadLine();
                    }
                    if (num == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        var list1 = Menu.MainDishes;
                        Console.WriteLine("*MainDishes:");
                        for (int i = 0; i < list1.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{list1[i].name}-{list1[i].price}");
                        }
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine();
                        Console.WriteLine();
                        var list2 = Menu.Appetizers;
                        Console.WriteLine("*Appetizers:");
                        int j = 8;
                        for (int i = 0; i < list2.Count; i++)
                        {
                            Console.WriteLine($"{j}.{list2[i].name}-{list2[i].price}");
                            j++;

                        }
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine();
                        Console.WriteLine();
                        var list3 = Menu.Drinks;
                        Console.WriteLine("*Drinks:");
                        j = 12;
                        for (int i = 0; i < list3.Count; i++)
                        {
                            Console.WriteLine($"{j}.{list3[i].name}-{list3[i].price}");
                            j++;
                        }
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine();
                        Console.WriteLine();
                        var list4 = Menu.Deserts;
                        Console.WriteLine("*Deserts:");
                        j = 16;
                        for (int i = 0; i < list4.Count; i++)
                        {
                            Console.WriteLine($"{j}.{list4[i].name}-{list4[i].price}");
                            j++;
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("1.Add item\n2.Remove item");
                       
                        Console.WriteLine();
                        Console.Write("Enter number choice:");
                        choice = Console.ReadLine();
                        int cas;
                        while (!int.TryParse(choice, out cas) || cas < 1 || cas > 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("invalid choice \n try again ");
                            choice = Console.ReadLine();
                        }
                        if (cas == 1)
                        {
                            Order.AddItem(listitem);
                        }
                        if (cas == 2)
                        {
                            Order.RemoveItem(listitem);
                        }

                        Console.WriteLine();
                    }
                    else if (num == 2)
                    {
                        Order.ViewOrder(listitem);
                        Console.WriteLine();
                    }
                    else if (num == 3)
                    {
                       Console.ForegroundColor= ConsoleColor.Cyan;
                        double billing = Billing.CalculateBilling();
                        Console.WriteLine($"total Billing before tax ={Order.totalprice()}");
                        Console.WriteLine($"total Billing after tax ={billing}");
                        Console.WriteLine("1.Card\n2.MobileWallet\n3.Cash");
                        Console.Write("Enter number choice to Payment:");
                        choice = Console.ReadLine();
                        int n;
                        while (!int.TryParse(choice, out n) || n < 1 || n > 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("invalid choice \n try again ");
                            choice = Console.ReadLine();
                        }
                        if (n == 1)
                        {
                            Payment.card();
                        }
                        else if (n == 2)
                        {
                            Payment.MobileWallet();
                        }
                        else if (n == 3)
                        {
                            Payment.Cash();
                        }
                        Console.WriteLine();
                    }
                    else if (num == 4)
                    {
                        index = Customer.login(list);
                        if (index != -1)
                        {
                            Customer.Updateprofile(list,index);
                        }

                    }
                    else if (num == 5)
                    {
                        break;
                    }
                   
                }
           }
        }
    }
}
