using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace COMP003A.Final
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Volunteer> volunteers = new List<Volunteer>();


            // TEMPORARY
            
            
            Console.WriteLine("-------------------------------------\n" +
                              "Welcome to the Volunteer database!\n" +
                              "-------------------------------------");
            volunteers.Add(new Volunteer("name", "race", "eye", "hair", "town", "origin", "prevvolunteerwork", 2020, 18, 60, 69, 47, 457, 57, 57, 57, true, true, true, true));
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
                Console.WriteLine(volunteers[0].Name);


                // user choices
                switch (menuSelect)
                {
                    //Add
                    case "1":
                        
                        continue;

                    // View
                    case "2":


                        continue;

                    // Search
                    case "3":


                        continue;

                    // Stats
                    case "4":


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

        public void Additions(List<Volunteer> volunteers)
        {

        volunteers.Add(new Volunteer("name", "race", "eye", "hair", "town", "origin", "prevvolunteerwork", 2020, 18, 60, 69, 47, 457, 57, 57, 57, true, true, true, true));
       
        }
    }
}
