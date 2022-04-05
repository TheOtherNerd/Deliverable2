using System;

namespace Deliverable2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int party = 0;
            bool realInt = false;
            int coffeeOrders = 0;
            int waterOrders = 0;

            Console.WriteLine("Welcome to the all you can eat buffet! We charge $9.99 per person, " +
                "$2.00 for coffee and water is free. We can seat up to 6 at a time. How many people do you have today?");
           string partyNum = Console.ReadLine();
            realInt = int.TryParse(partyNum, out party);

            if (party < 7 && party > 0)
            {
                Console.WriteLine("A table for " + party + "! Right this way please!");
                for (int i = 0; i < party; i++)
                {
                    Console.WriteLine("Okay, coffee or water person " + (i+1) + "?");
                   string order = Console.ReadLine();
                    if(order == "coffee")
                    {
                        Console.WriteLine("Coffee, okay!");
                        coffeeOrders++;
                    }else if (order == "water")
                    {
                        Console.WriteLine("Water, okay!");
                        waterOrders++;
                    }
                    else
                    {
                        Console.WriteLine("We don't have that. Nothing for you then!");
                    }
                }
                Console.WriteLine("Okay, that's " + coffeeOrders + " coffees and " + waterOrders + " waters. Feel free to grab your food!");
                double bill = (party * 9.99) + (coffeeOrders * 2.00);
                Console.WriteLine("Here's your bill! Total price: $" + bill);
                Console.ReadLine();
            }
            else
            {
                //make em leave cause not a number or above 6
                Console.WriteLine("Sorry, we can only seat up to 6! Please come again!");
                Console.ReadLine();
            }
        }
    }
}
