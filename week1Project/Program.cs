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
            // Ask the user for input allowing them to quit.
            Console.WriteLine("\t\t\t\"The Fortune Teller\"\n\nYou can type \"Quit\" at any point to stop.\nPress the Enter key to begin.");
            string cont = Console.ReadLine();
            string lowercont = cont.ToLower();
            if (lowercont == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
            Console.WriteLine("What's your first name?");
            string firstName = Console.ReadLine();
            string lowerFirstName = firstName.ToLower();
            if (lowerFirstName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
            return;
            }
             
            Console.WriteLine("What's your last name?");
            string lastName = Console.ReadLine();
            string lowerLastName = lastName.ToLower();
            if (lowerLastName == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
                   
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            if (age.ToString() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }                        
            Console.WriteLine("What number month were you born? (e.g. 8 is for August)");
            int birthMonth = int.Parse(Console.ReadLine());
            if (birthMonth.ToString() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
                            
            Console.WriteLine("How many siblings do you have?");
            int sibling = int.Parse(Console.ReadLine());
            if (sibling.ToString() == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
                               
            //Ask the user for input and provide help options
            Console.WriteLine("What's your favorite ROYGBIV color?\n -Type \"Help\" if you don't know what ROYGBIV is.");
            string roygbiv = Console.ReadLine();
            string lowerRoygbiv = roygbiv.ToLower();
            if (lowerRoygbiv == "quit")
            {
                Console.WriteLine("Nobody likes a quitter...");
                return;
            }
                                   
            while (lowerRoygbiv == "help")
            {
                switch (lowerRoygbiv)
                {
                    case "help":
                        {
                            Console.WriteLine("ROYGBIV stands for Red, Orange, Yellow, Green, Blue, Indigo and Violet.");
                            lowerRoygbiv = Console.ReadLine();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
                                        
            //Determining user fortune
            string retiringInYears;
            string vacationHome;
            string transportationMode;
            string moneyInBank;

            if (age % 2 == 0)
            {
                retiringInYears = "20";
            }
            else
            {
                retiringInYears = "30";
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
                case "red":
                    {
                        transportationMode = "a car";
                        break;
                    }
                case "orange":
                    {
                        transportationMode = "a luxury car";
                        break;
                    }
                case "yellow":
                    {
                        transportationMode = "a helicopter";
                        break;
                    }
                case "green":
                    {
                        transportationMode = "a flying luxury car";
                        break;
                    }
                case "blue":
                    {
                        transportationMode = "a boat";
                        break;
                    }
                case "indigo":
                    {
                        transportationMode = "a submarine";
                        break;
                    }
                case "violet":
                    {
                        transportationMode = "a rocket";
                        break;
                    }
                default:
                    {
                        transportationMode = "nothing";
                        break;
                    }
            }

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                moneyInBank = "$1,000,001.98";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                moneyInBank = "$6,865,444.07";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                moneyInBank = "$3,500,067.63";
            }
            else
            {
                moneyInBank = "$0.00";
            }

            //Printing out the users fortune
            Console.WriteLine("{0} {1} will retire in {2} years with {3} in the bank,\na vacation home in {4} and {5} for transportation.", firstName, lastName, retiringInYears, moneyInBank, vacationHome, transportationMode);

        }

    }
}
                            