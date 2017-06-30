using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1Project
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ask the user for input
            Console.WriteLine("Type \"Quit\" at any point to stop.");

            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();
            string lowerFirstName = firstName.ToLower();

            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();
            string lowerLastName = lastName.ToLower();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What number month were you born? (e.g. 8 is for August)");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int sibling = int.Parse(Console.ReadLine());

            //Ask the user for input and provide help options
            Console.WriteLine("What's your favorite ROYGBIV color?\n -Type \"Help\" if you don't know what ROYGBIV is.");
            string roygbiv = Console.ReadLine();
            string lowerRoygbiv = roygbiv.ToLower();
            if (lowerRoygbiv == "help")
            {
                Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Blue, Indigo and Violet.");
                roygbiv = Console.ReadLine();
            }
                        
            //Determining user fortune
            int retiringInYears;
            string vacationHome;
            string transportationMode;
            double moneyInBank;

            if (age % 2 == 0)
            {
                retiringInYears = 20;
            }
            else
            {
                retiringInYears = 30;
            }

            if (sibling == 0)
            {
                vacationHome = "Cancun";
            }
            else if (sibling == 1)
            {
                vacationHome = "Sydney";
            }
            else if (sibling == 2)
            {
                vacationHome = "California";
            }
            else if (sibling == 3)
            {
                vacationHome = "Put-In Bay";
            }
            else if (sibling < 0)
            {
                vacationHome = "Shopping Cart";
            }
            else
            {
                vacationHome = "Washington";
            }

            switch (lowerRoygbiv)
            {
                case red:
                    {
                        transportationMode = "Car";
                        break;
                    }
                case orange:
                    {
                        transportationMode = "Car";
                        break;
                    }
                case yellow:
                    {
                        transportationMode = "Car";
                        break;
                    }
                case green:
                    {
                        transportationMode = "Car";
                        break;
                    }
                case blue:
                    {
                        transportationMode = "Car";
                        break;
                    }
                case indigo:
                    {
                        transportationMode = "Car";
                        break;
                    }
                case violet:
                    {
                        transportationMode = "Car";
                        break;
                    }
                default:
                    {
                        transportationMode = "nothing";
                        break;
                    }
            }

            if (birthMonth >=1 && birthMonth <= 4)
            {
                moneyInBank = 1000001.98;
            }
            else if (birthMonth >=5 && birthMonth <= 8)
            {
                moneyInBank = 6865444.07;
            }
            else if (birthMonth >=9 && birthMonth <= 12)
            {
                moneyInBank = 3500067.63;
            }
            else
            {
                moneyInBank = 0.00;
            }
            Console.WriteLine(moneyInBank + retiringInYears + vacationHome + transportationMode);
            // The user’s fortune should be written as such:
            // [First Name] [Last Name] will retire in [# of Years] with [Amount of Money] in the bank, a vacation home in [Location] and a [Mode of Transportation].
            // Program should be able to handle whether or not a user inputs capital or lowercase letters.



            //Give the user the ability to quit the program at any point where the program is looking for user input, by typing “Quit” (should not be case sensitive). The program should print “Nobody likes a quitter...” before ending.
        }
    }
}
