namespace TrainingEx
{
    using System;

    class Program
    {
        static List<(string Product, int Quantity)> purchasedProducts = new List<(string Product, int Quantity)>();
        static void SecondScreen()
        {
            Console.Clear();
            Console.WriteLine("List of available Products:");
            Console.WriteLine("1. Blue");
            Console.WriteLine("2. White");
            Console.WriteLine("3. Black");
            Console.WriteLine("4. Orange");

            Console.WriteLine("Enter the S.No. of the product you want to purchase: ");
            int selectedproduct = Convert.ToInt32(Console.ReadLine());

            string productname = "";

            switch (selectedproduct)
            {
                case 1:
                    productname = "Red";
                    break;
                case 2:
                    productname = "White";
                    break;
                case 3:
                    productname = "Black";
                    break;
                case 4:
                    productname = "Orange";
                    break;
                default:
                    Console.WriteLine("Please enter valid selection.");
                    return;
            }

            Console.WriteLine($"You selected {productname}.");
            ThirdScreen(productname);
        }

        static void ThirdScreen(string selectedproduct)
        {
            Console.Clear();
            Console.WriteLine($"Enter the required quantity of {selectedproduct}: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"You have selected {quantity} {selectedproduct}(s).");

            purchasedProducts.Add((selectedproduct, quantity));

            FourthScreen();
        }

        static void FourthScreen()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Move to checkout");
            Console.WriteLine("2. Go back to product selection");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                CheckoutScreen();
            }
            else if (choice == 2)
            {
                SecondScreen();
            }
            else
            {
                Console.WriteLine("Please enter a valid choice.");
            }
        }

        static void CheckoutScreen()
        {
            Console.WriteLine("Proceeding to checkout. Please be patient.");

            FinalScreen();
        }
        static void FinalScreen()
        {
            Console.WriteLine("Purchased Products:");
            foreach (var item in purchasedProducts)
            {
                Console.WriteLine($"{item.Product}: {item.Quantity}");
            }
            Console.WriteLine("Thank you for ordering! Please come back soon!");
        }

        static void Main(string[] args)
        {

            const int password = 123;

            
            Console.WriteLine("Enter username: ");
            string inputusername = Console.ReadLine();


            Console.WriteLine("Enter password: ");
            int inputpassword = Convert.ToInt32(Console.ReadLine());

            if (inputpassword == password)
            {
                Console.WriteLine("Login Successfull");
           
                SecondScreen();
            }
            else
            {
                Console.WriteLine("Please login again.");
            }
        }  

    }

}
