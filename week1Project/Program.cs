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
            Console.WriteLine("\t\t\t\t\"The Fortune Teller\"\n"
                + "________________________________________________________________________________"
                + "Press the Enter key to begin.\t\t\tType \"Quit\" to exit at any time."
                + "________________________________________________________________________________");

            string cont = Console.ReadLine();
            string lowercont = cont.ToLower();
            if (lowercont == "quit")
            { Console.WriteLine("Nobody likes a quitter..."); }
            else
            {
                Console.Write("Enter your first name:\t\t\t");
                string firstName = Console.ReadLine();
                string lowerFirstName = firstName.ToLower();
                if (lowerFirstName == "quit")
                { Console.WriteLine("Nobody likes a quitter..."); }
                else
                {
                    Console.Write("Enter your last name:\t\t\t");
                    string lastName = Console.ReadLine();
                    string lowerLastName = lastName.ToLower();
                    if (lowerLastName == "quit")
                    { Console.WriteLine("Nobody likes a quitter..."); }
                    else
                    {
                        Console.Write("Enter your age:\t\t\t\t");
                        string age = Console.ReadLine();
                        string lowerAge = age.ToLower();
                        if (lowerAge == "quit")
                        { Console.WriteLine("Nobody likes a quitter..."); }
                        else
                        {
                            Console.Write("Enter your two-digit birth month:\t");
                            string birthMonth = Console.ReadLine();
                            string lowerBirthMonth = birthMonth.ToLower();
                            if (lowerBirthMonth == "quit")
                            { Console.WriteLine("Nobody likes a quitter..."); }
                            else
                            {
                                Console.Write("Enter the number of siblings you have:\t");
                                string sibling = Console.ReadLine();
                                string lowerSibling = sibling.ToLower();
                                if (lowerSibling == "quit")
                                { Console.WriteLine("Nobody likes a quitter..."); }
                                else
                                {
                                    Console.Write("Enter your favorite ROYGBIV color:\t"
                                        + "\nType \"Help\" for ROYGBIV options.\t");
                                    string roygbiv = Console.ReadLine();
                                    string lowerRoygbiv = roygbiv.ToLower();
                                    if (lowerRoygbiv == "quit")
                                    { Console.WriteLine("Nobody likes a quitter..."); }
                                    else
                                    {
                                        if (lowerRoygbiv == "help")
                                        {
                                            Console.Write("R - Red\nO - Orange\nY - Yellow\nG - Green\nB - Blue\nI - Indigo\nV - Violet"
                                                + "\n\nEnter your favorite ROYGBIV color:\t");
                                            lowerRoygbiv = Console.ReadLine();
                                        }
                                            //Determining user fortune
                                            string retiringInYears;
                                            string vacationHome;
                                            string transportationMode;
                                            string moneyInBank;

                                            if (int.Parse(age) % 2 == 0) { retiringInYears = "20"; }
                                            else { retiringInYears = "30"; }

                                            if (int.Parse(sibling) == 0)
                                            { vacationHome = "Cancun"; }
                                            else if (int.Parse(sibling) == 1)
                                            { vacationHome = "Sydney"; }
                                            else if (int.Parse(sibling) == 2)
                                            { vacationHome = "California"; }
                                            else if (int.Parse(sibling) == 3)
                                            { vacationHome = "Put-In Bay"; }
                                            else if (int.Parse(sibling) < 0)
                                            { vacationHome = "Shopping Cart"; }
                                            else
                                            { vacationHome = "Washington"; }

                                            switch (lowerRoygbiv)
                                            {
                                                case "red":
                                                    { transportationMode = "a car"; break; }
                                                case "orange":
                                                    { transportationMode = "a luxury car"; break; }
                                                case "yellow":
                                                    { transportationMode = "a helicopter"; break; }
                                                case "green":
                                                    { transportationMode = "a flying luxury car"; break; }
                                                case "blue":
                                                    { transportationMode = "a boat"; break; }
                                                case "indigo":
                                                    { transportationMode = "a submarine"; break; }
                                                case "violet":
                                                    { transportationMode = "a scooter"; break; }
                                                default:
                                                    { transportationMode = "nothing"; break; }
                                            }

                                            if (int.Parse(birthMonth) >= 1 && int.Parse(birthMonth) <= 4)
                                            { moneyInBank = "$1,000,001.98"; }
                                            else if (int.Parse(birthMonth) >= 5 && int.Parse(birthMonth) <= 8)
                                            { moneyInBank = "$6,865,444.07"; }
                                            else if (int.Parse(birthMonth) >= 9 && int.Parse(birthMonth) <= 12)
                                            { moneyInBank = "$3,500,067.63"; }
                                            else
                                            { moneyInBank = "$0.00"; }

                                            //Printing out the users fortune
                                            Console.WriteLine("\n\t\t\t\t\"The Fortune\"\n\n{0} {1} will retire in {2} years with {3} "
                                                + "in the bank,\na vacation home in {4} and {5} for transportation.\n",
                                                firstName, lastName, retiringInYears, moneyInBank, vacationHome, transportationMode);

                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
