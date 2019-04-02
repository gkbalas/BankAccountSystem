using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerList = new List<Customer>();
            bool mainQuit = true;
            int mainMenu = new int();
            while (mainQuit)
            {
                Console.WriteLine("Menu\n1. New customer\n2. Existing customer\n3. Quit");

                try
                {
                    mainMenu = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {

                    throw;
                }
                switch (mainMenu)
                {
                    case 1: // Ask some info and add the new customer to customerList
                        customerList.Add(new Customer());
                        customerList[customerList.Count - 1].OpenAccount();
                        break;
                    case 2: // Find the customer in customerList and open new menu
                        Console.WriteLine("What is your first name?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is your last name?");
                        string lastName = Console.ReadLine();
                        Customer menuCustomer = new Customer();
                        bool found = false;
                        foreach (Customer customer in customerList)
                        {
                            if (customer.LastName.ToLower().Equals(lastName.ToLower()) && 
                                customer.FirstName.ToLower().Equals(firstName.ToLower()))
                            {
                                
                                customer.Menu(); // Open customer menu
                                found = true;
                            }

                        }
                        if (!found)
                        {
                            Console.WriteLine("There is not your name in our database, check for misspelling\n");
                        }
                        break;
                    case 3:
                        mainQuit = false;
                        break; 
                    default:
                        Console.WriteLine("You should give the proper number");
                        break;
                }

            }




            Console.ReadKey();
        }
    }
}
