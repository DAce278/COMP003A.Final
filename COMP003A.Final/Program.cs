using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
namespace COMP003A.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Volunteer> volunteers = new List<Volunteer>();

            Console.WriteLine("-------------------------------------\n" +
                              "Welcome to the Volunteer database!\n" +
                              "-------------------------------------");
            

            Menu(volunteers);
        }

        static void Menu(List<Volunteer> volunteers)
        {
        while (true)
                    {
                        Console.Write("\n" +
                                      "\nPlease select an option:" +
                                      "\n1. Create New Profile" +
                                      "\n2. View All Profiles" +
                                      "\n3. Search Profiles" +
                                      "\n4. Summary Statistics" +
                                      "\n5. Exit" +
                                      "\nOption Selection: ");
                        string menuSelect = Console.ReadLine();

                        // user choices
                        switch (menuSelect)
                        {
                            //Add
                            case "1":
                        
                                Additions(volunteers);
                                continue;

                            // View
                            case "2":

                                View(volunteers);
                                continue;

                            // Search
                            case "3":

                                Search(volunteers);
                                continue;

                            // Stats
                            case "4":

                                Stats(volunteers);
                                continue;
                        
                            // Exit
                            case "5":
                                Console.WriteLine("\n\nGoodbye!");
                                break;

                            default:

                                Console.WriteLine("Unknown selection, please try again.");
                                continue;
                        }

                        break;
                    }
        }

        static void Additions(List<Volunteer> volunteers)
        {
            Console.WriteLine("\nPlease enter your name: ");
            string nameInput = Console.ReadLine();

            volunteers.Add(new Volunteer(nameInput, "race", "eye", "hair", "town", "origin", "prevvolunteerwork", 2020, 18, 60, 45, 69, 47, 457, 57, 57, 57, true, true, true, true, true));
       
        }
        static void View(List<Volunteer> volunteers)
        {
            Console.WriteLine();
            int i = 0;
            foreach (Volunteer volunteer in volunteers)
            {
                i++;
                Console.WriteLine(i + ". " + volunteer.Name + ": " + volunteer.Age + " years old - Residing in " + volunteer.Town);

            }
        }

        static void Search(List<Volunteer> volunteers)
        {
            Console.Write("\nWho would you like to search for?: ");
            string nameSearch = "";
            nameSearch = Console.ReadLine();
        }

        static void Stats(List<Volunteer> volunteers)
        {
            
        }

        public static int IntegerVerification(string unverifiedInt)
        {
            try
            {
                int.Parse(unverifiedInt);
            }
            catch (FormatException)
            {
                // turns values into -1 if it can't be parsed
                Console.WriteLine("Error: Integer not entered.");
                unverifiedInt = "-1";
                
                
            }
            int verifiedInt = int.Parse(unverifiedInt);
            return verifiedInt;
        }

        public static bool YesNoVerification(string unverifiedBool)
        {
            bool isTrue;

            if (unverifiedBool == "yes")
            {
                isTrue = true;
            }
            else if (unverifiedBool == "no")
            {
                isTrue = false;
            }
            else
            {
                Console.WriteLine("Unknown response.");
                isTrue = false;
            }
            return isTrue;
        }


    }
}
