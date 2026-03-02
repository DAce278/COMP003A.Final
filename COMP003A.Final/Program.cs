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


        //User add logic
        static void Additions(List<Volunteer> volunteers)
        {
            // non-conditional string returns
            string newName = NameRequest();
            string newRace = RaceRequest();
            string newEyeColor = EyeRequest();
            string newHairColor = HairRequest();
            string newTown = TownRequest();
            string newOrigin = OriginRequest();

            // integer returns
            int newBirthYear = BirthYearRequest();
            int estimatedAge = (2026 - newBirthYear); // no method, calculation based on birth year
            int newHeight = HeightRequest();
            int newWeight = WeightRequest();
            
            int estimatedBMI = (newWeight / (newHeight * newHeight)); // based on height and weight NEED TO BE DOUBLE
            int newExpectedHours = ExpectedHourRequest();
            int newExperienceMonths = ExperienceMonthsRequest();
            int newVolunteerHours = VolunteerHoursRequest();
            int newApplicantNumber = 0; // 

            // conditional returns

            string newPrevVolunteering = PrevVolunteeringRequest();
            int newWeightLift = WeightLiftRequest();

            volunteers.Add(new Volunteer(newName, newRace, newEyeColor, newHairColor, newTown, newOrigin, newPrevVolunteering, newBirthYear, estimatedAge, newHeight, newExpectedHours, newExperienceMonths, newVolunteerHours, newWeight, newWeightLift, estimatedBMI, newApplicantNumber, true, true, true, true, true));
       

            // STRING request methods
            static string NameRequest()
            {
                Console.WriteLine("Please enter your name: ");
                string nameInput = Console.ReadLine();
                return nameInput;
            }
            static string RaceRequest()
            {
                Console.WriteLine("Please enter your race: ");
                string raceInput = Console.ReadLine();
                return raceInput;
            }
            static string EyeRequest()
            {
                Console.WriteLine("Please enter your eye color: ");
                string EyeInput = Console.ReadLine();
                return EyeInput;
            }
            static string HairRequest()
            {
                Console.WriteLine("Please enter your hair color: ");
                string hairInput = Console.ReadLine();
                return hairInput;
            }
            static string TownRequest()
            {
                Console.WriteLine("Please enter the town you reside in: ");
                string TownInput = Console.ReadLine();
                return TownInput;
            }
            static string OriginRequest()
            {
                Console.WriteLine("Please enter the state or country you were born in: ");
                string OriginInput = Console.ReadLine();
                return OriginInput;
            }

            // CONDITIONAL - only asked if "yes" was answered to "Have you previously volunteered?"
            static string PrevVolunteeringRequest()
            {
                Console.WriteLine("Please state the most recent volunteer program you've participated in: ");
                string prevVolunteeringInput = Console.ReadLine();
                return prevVolunteeringInput;
            }


            // NUMBER-BASSED request methods
            static int BirthYearRequest()
            {
                Console.WriteLine("What year were you born in?: ");
                int birthYearInput = IntegerVerification(Console.ReadLine());
                return birthYearInput;
            }
            static int HeightRequest()
            {
                Console.WriteLine("How tall are you in inches (rounded to the nearest whole number)?: ");
                int heightInput = IntegerVerification(Console.ReadLine());
                return heightInput;
            }
            static int WeightRequest()
            {
                Console.WriteLine("How much do you weigh?: ");
                int weightInput = IntegerVerification(Console.ReadLine());
                return weightInput;
            }
            static int WeightLiftRequest() // CONDITIONAL - based on if "yes" was answered to "do you work out?"
            {
                Console.WriteLine("How much have you been able to bench press?: ");
                int weightLiftInput = IntegerVerification(Console.ReadLine());
                return weightLiftInput;
            }
            static int ExpectedHourRequest()
            {
                Console.WriteLine("How many hours do you expect to volunteer (per week)?: ");
                int expectedHoursInput = IntegerVerification(Console.ReadLine());
                return expectedHoursInput;
            }
            static int ExperienceMonthsRequest() // CONDITIONAL - only asked if "yes" was answered to "Have you previously volunteered?"
            {
                Console.WriteLine("How many months have you volunteered in total?: ");
                int experienceMonthsInput = IntegerVerification(Console.ReadLine());
                return experienceMonthsInput;
            }
            static int VolunteerHoursRequest() // CONDITIONAL - only asked if "yes" was answered to "Have you previously volunteered?"
            {
                Console.WriteLine("How many hours of volunteering do you have?: ");
                int VolunteerInput = IntegerVerification(Console.ReadLine());
                return VolunteerInput;
            }

            // BOOL request methods
        }





        // View all logic
        static void View(List<Volunteer> volunteers)
        {
            Console.WriteLine();
            int i = 0;
            foreach (Volunteer volunteer in volunteers)
            {
                i++;
                Console.WriteLine(i + ". " + volunteer.Name + ": " + volunteer.Age + " years old - Residing in " + volunteer.Town + "Applicant #:" + volunteer.ApplicantNum);

            }
        }


        // Search logic
        static void Search(List<Volunteer> volunteers)
        {
            Console.Write("\nWho would you like to search for?: ");
            string nameSearch = "";
            nameSearch = Console.ReadLine();
        }

        static void Stats(List<Volunteer> volunteers)
        {
            
        }


        // Validation logic
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
