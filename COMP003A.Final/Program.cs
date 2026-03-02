using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
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

        volunteers.Add(new Volunteer(nameInput, "race", "eye", "hair", "town", "origin", "prevvolunteerwork", 2020, 18, 60, 69, 47, 457, 57, 57, 57, true, true, true, true));
       
        }
        static void View(List<Volunteer> volunteers)
        {
            Console.WriteLine();
            int i = 0;
            foreach (Volunteer volunteer in volunteers)
            {
                i++;
                Console.WriteLine(i + ". " + volunteer.Name);

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


    }
}
