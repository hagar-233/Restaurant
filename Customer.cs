using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using ConsoleApp131;

namespace ConsoleApp131
{
    public class Customer
    {
        public string Name;
        public string UserName;
        public string Password;
        public string Address;
        public string Phone;
       public static int AddAcccount(List<Customer> list)
       {
            Console.WriteLine("========Create Profile========");
            Console.ForegroundColor = ConsoleColor.Blue;
            Customer customer = new Customer();
            
            Console.Write("Enter Name:");
            customer.Name = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(customer.Name) || int.TryParse(customer.Name, out _))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect name");
                Console.Write("Enter Name:");
                customer.Name = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter UserName:");
            customer.UserName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(customer.UserName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect username");
                Console.Write("Enter UserName:");
                customer.UserName = Console.ReadLine();
            }
            
            Console.Write("Enter Password:");
            customer.Password = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(customer.Password))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect password");
                Console.Write("Enter Password:");
                customer.Password = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter PhoneNumber:");
            customer.Phone = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(customer.Phone) || !customer.Phone.All(char.IsDigit) || customer.Phone.Length < 11)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect phone number");
                Console.Write("Enter PhoneNumber:");
                customer.Phone = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter address:");
            customer.Address = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(customer.Address))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect address");
                customer.Address = Console.ReadLine();
            }
            list.Add(customer);
            Customer.SaveData(list);
            return list.Count - 1;
       }
        public static void SaveData(List<Customer> list)
        {

            using (StreamWriter s = new StreamWriter(@"E:\Customer.txt", false))
            {
                foreach (Customer customer in list)
                {
                    s.WriteLine($"{customer.Name},{customer.UserName},{customer.Address},{customer.Password},{customer.Phone}");
                }
            }


        }
 public static void ViewProfile(int index, List<Customer> list)
  {
      Console.ForegroundColor = ConsoleColor.Magenta;
      Console.WriteLine("========Update Profile========");
      Console.WriteLine($"Name:{list[index].Name}");
      Console.WriteLine($"UserName:{list[index].UserName}");
      Console.WriteLine($"PhoneNumber:{list[index].Phone}");
      Console.WriteLine($"Address:{list[index].Address}");
  }
        public static int login(List<Customer> list)
        {
            Console.WriteLine("========Login========");
            Console.Write("Enter UserName:");
            string user=Console.ReadLine();
            while (user == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect username");
                Console.Write("Enter UserName:");
                user = Console.ReadLine();
            }
            Console.Write("Enter Password:");
            string pass=Console.ReadLine();
            while (pass == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorect Password");
                Console.Write("Enter UserName:");
                pass = Console.ReadLine();
            }
           
           
            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i].Name + "" + list[i].Password);
                if (pass == list[i].Password && user == list[i].UserName)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Login successful !");
                      
                    return i;
                    

                }
                
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Incorrect username or password");
            return -1;

        }
        public static void Updateprofile(List<Customer> list,int index )
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("========Update Profile========");
            Console.WriteLine("What do you want to update?");
            Console.WriteLine("1. Name");
            Console.WriteLine("2. Phone number");
            Console.WriteLine("3. Password");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            int num;
            while (!int.TryParse(choice, out num) || num < 1 || num > 3)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("invalid choice \n try again ");
                choice = Console.ReadLine();
            }
            if (num == 1)
            {
                Console.Write("Enter New Name:");
                
                list[index].Name = Console.ReadLine();
                while (list[index].Name == null || int.TryParse(list[index].Name, out _))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorect name");
                    Console.Write("Enter Name:");
                   list[index].Name = Console.ReadLine();
                }

            }
            else if (num == 2)
            {
                Console.Write("Enter New Phone number:");
               
                list[index].Phone = Console.ReadLine();
                while (list[index].Phone == null || int.TryParse(list[index].Phone, out _))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorect phone number");
                    Console.Write("Enter Phone number:");
                    list[index].Phone = Console.ReadLine();
                }
            }
            else if (num == 3)
            {
                Console.Write("Enter New Password:");
              
                list[index].Password = Console.ReadLine();
                while (list[index].Password == null || int.TryParse(list[index].Password, out _))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("incorect Password");
                    Console.Write("Enter new Password:");
                    list[index].Password = Console.ReadLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Profile updated successfully !");
            SaveData(list);
        }
       public static List<Customer>  LoadData()
        {
            List<Customer> list = new List<Customer>();
            if (File.Exists(@"E:\Customer.txt"))
            {
                string[] array = File.ReadAllLines(@"E:\Customer.txt");
                foreach(var i in array)
                {
                    var part = i.Split(',');
                    if (part.Length == 5)
                    {
                        list.Add(new Customer
                        {
                            Name = part[0],
                            UserName = part[1],
                            Address = part[2],
                            Password = part[3],
                            Phone = part[4]
                        });

                           
                    }
                }
            }
            return list;

       }

        
    }
}

