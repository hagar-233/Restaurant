# Restaurant
🍔 Restaurant Ordering System
📌 Overview

Restaurant Ordering System is a console-based application built with C# that simulates a complete food ordering process in a restaurant.
It allows customers to create accounts, log in, browse menus, place and manage orders, calculate billing with tax, and make payments using different methods.

This project demonstrates fundamental programming concepts like:

Object-Oriented Programming (OOP)

File handling (save/load data from .txt files)

User input validation

Data structures (Lists)

Basic console UI design

🛠️ Features
👤 Customer Management

Create a new account with validation (name, username, password, phone, address).

Log in using username and password.

Update profile details (name, phone number, or password).

Customer data is stored and retrieved from a text file (Customer.txt).

🍽️ Menu Browsing

View categorized menu items:

Main Dishes 🍔

Appetizers 🥗

Drinks 🥤

Desserts 🍰

🛒 Order Management

Add items to your order from the menu.

Remove items from the order.

View a summary of your current order, including total cost.

Orders are saved and loaded from items.txt.

💰 Billing

Calculates the total cost of the order.

Adds tax (18.2%) to the final bill.

Displays billing before and after tax.

💳 Payment Options

Pay by Card – enter card number, cardholder name, and CVV.

Pay by Mobile Wallet – enter phone number.

Pay by Cash – choose cash on delivery option.

🧱 Project Structure
RestaurantOrderingSystem/
│
├─ Program.cs          // Main entry point and user interface flow
├─ Customer.cs         // Customer registration, login, update, and data storage
├─ Menu.cs             // Menu items categorized into lists
├─ Order.cs            // Add, remove, view orders, calculate total price
├─ Billing.cs          // Billing calculation with tax
├─ Payment.cs          // Payment methods handling
│
├─ Customer.txt        // Stores customer information
└─ items.txt           // Stores order details

⚙️ How to Run
📋 Requirements

.NET SDK (v6.0 or higher)

Visual Studio or any C# compatible IDE

▶️ Steps

Clone or download the project to your local machine.

Open the solution in Visual Studio.

Make sure the file paths in Customer.cs and Order.cs (E:\Customer.txt and E:\items.txt) are correct or update them to your preferred directory.

Build and run the project.

Follow the on-screen instructions to create an account, browse the menu, place orders, and complete payment.

📊 Sample Workflow

Start the program – Welcome screen appears.

Create account / Login – Register or log in to continue.

View Menu – Browse items in different categories.

Add or Remove Items – Customize your order.

View Order – Check your current selections.

Payment – Choose a payment method and finalize your order.

📂 Example Output
*************
  Restaurant
*************

1. Create new account
2. Login
3. Exit

Enter your choice: 1
========Create Profile========
Enter Name: John Doe
Enter UserName: johnd
Enter Password: *****
Enter PhoneNumber: 01234567890
Enter Address: Main Street 12

===========Your Order=====================
Item Name            Quantity   Total Price
-------------------------------------------
Classic Burger       2          110
Cola                 1          15
-------------------------------------------
Total before tax = 125
Total after tax  = 147.75

🧠 Concepts Demonstrated

Object-Oriented Programming (Classes, Methods, Objects)

File I/O operations for data persistence

Data validation and error handling

Console-based UI interaction

Modular programming and clean project structure

📌 Future Improvements

Add order history tracking.

Implement discounts or promotional codes.

Create a graphical user interface (GUI) using Windows Forms or WPF.

Integrate with a database instead of text files.

👩‍💻 Author

Developed as a C# console application project to demonstrate object-oriented design, file handling, and user interaction logic in a restaurant ordering context.
