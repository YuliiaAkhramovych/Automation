using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Store
    {
        static void Main()
        {
            Dictionary<String, String> users = new Dictionary<string, string>();
            users.Add("Bob", "bob");
            users.Add("Alice", "alice");
            users.Add("Kate", "kate");
            List<string> stuff = new List<string>() { "pen", "car", "laptop" };

            Console.WriteLine("Hi there! Please select an option by number.");
            Console.WriteLine(1 + " - LogIn with existing user");
            Console.WriteLine(2 + " - Create an account");
            Console.WriteLine(3 + " - Exit");

            int n = 0;
            bool isValid = int.TryParse(Console.ReadLine(), out n);
            if (isValid)
            {
                if (n == 1)
                {
                    Console.WriteLine("Please enter your username");
                    string username = Console.ReadLine();
                    bool isUserExist = users.ContainsKey(username);
                    if (isUserExist)
                    {
                        Console.WriteLine("Please enter your password");
                        string password = Console.ReadLine();
                        string userPassword = users.First(e => e.Key.Equals(username)).Value;
                        if (password == userPassword)
                        {
                            Console.WriteLine("Hello " + username + "!");
                            SelectStuff();
                        }
                        else
                        {
                            Console.WriteLine("Invalid password");
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, there is no such user.");
                        Console.ReadLine();
                    }
                }
                else if (n == 2)
                {
                    CreateAccount();
                }
                else if (n == 3)
                {
                    ExitAProgramm();
                }
                else
                {
                    Console.WriteLine("There is no such option");
                }
            }
            else
            {
                Console.WriteLine("Please, select number!");
            }


        }

        private static void SelectStuff()
        {
            List<string> stuff = new List<string>() { "pen", "car", "laptop" };
            List<string> boughtStuff = new List<string>() { };
            Console.WriteLine("Select a product you want to buy:");
            foreach (string element in stuff)
                Console.WriteLine(element);
            string selectedStuff = Console.ReadLine();
            bool isStuffPresent = stuff.Contains(selectedStuff);
            if (isStuffPresent)
            {
                boughtStuff.Add(selectedStuff);

                Console.WriteLine("You have bought:");
                foreach (string element in boughtStuff)
                    Console.WriteLine(element);
                Console.WriteLine("Do you want to buy something else?");
                Console.WriteLine("Yes / No");
                string option = Console.ReadLine();
                if (option == "Yes")
                {
                    SelectStuff();
                }
                else if (option == "No")
                {
                    Console.WriteLine("Thank you for choosing our shop! Good bye!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Select Yes or No");
                }
            }

            else
            {
                Console.WriteLine("Sorry, there is no such product at the momemt.");
                SelectStuff();
                Console.ReadLine();
            }
        }

        private static void CreateAccount()
        {
            Dictionary<String, String> users = new Dictionary<string, string>();
            users.Add("Bob", "bob");
            users.Add("Alice", "alice");
            users.Add("Kate", "kate");
            Console.WriteLine("Please provide login.");
            string newUsername = Console.ReadLine();
            bool ifAlreadyExist = users.ContainsKey(newUsername);
            if (ifAlreadyExist)
            {
                Console.WriteLine("Sorry, such login is already used.");
                CreateAccount();
            }
            else
            {
                Console.WriteLine("Provide a password");
                string newPassword = Console.ReadLine();
                bool isNotEmpty = newPassword != string.Empty;
                if (isNotEmpty)
                {
                    users.Add(newUsername, newPassword);
                    Console.WriteLine("Congratulations! You are successfully registered.");
                    SelectStuff();
                }
            }
        }
        private static void ExitAProgramm()
        {
            Console.WriteLine("Do you really want to exit?");
            Console.WriteLine("Yes / No");
            string newOption = Console.ReadLine();
            if (newOption == "Yes")
            {
                Console.WriteLine("Thank you for choosing our shop! Click Enter to exit.");
                Console.ReadLine();
            }
            else if (newOption == "No")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Select Yes or No");
            }
        }
    }
}


