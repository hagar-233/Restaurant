using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp131
{
    internal class Payment
    {
       

        public static void card()
        {
            Console.Write("Enter Card Number:");
            string Cardnumber=Console.ReadLine();
            while (string.IsNullOrWhiteSpace(Cardnumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Card number cannot be empty. Enter again:");
                Cardnumber = Console.ReadLine();
            }
            Console.Write("Enter Cardholder Name:");
            string CardholderName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(CardholderName))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Name number cannot be empty. Enter again:");
                CardholderName = Console.ReadLine();
            }
            Console.Write("Enter CVV:");
            string cvvinput = Console.ReadLine();
            int Cvv;
            while(!int.TryParse(cvvinput,out Cvv) || Cvv < 100 || Cvv > 999)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Invalid CVV . Enter a 3-digit number:");
                CardholderName = Console.ReadLine();

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Payment completed successfully by card");

        }
        public static void MobileWallet()
        {
            Console.Write("Enter phone number:");
            string phonenumber=Console.ReadLine();
            while (string.IsNullOrWhiteSpace(phonenumber))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Phone number cannot be empty. Enter again:");
                phonenumber = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Payment completed successfully by Mobile Wallet");
        }
        public static void Cash()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Cash on Delivery ");
        }

    }
}
