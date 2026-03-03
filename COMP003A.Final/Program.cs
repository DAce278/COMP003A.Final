using System.Collections.Generic;
namespace COMP003A.Final
{
    internal class Program
    {
        
        static public List<Volunteer> volunteers = new List<Volunteer>();
        public int i = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------------\n" +
                              "Welcome to the Volunteer database!\n" +
                              "-------------------------------------");
            

            Menu();
        }
    

        static void Menu()
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
                        
                                Additions();
                                continue;

                            // View
                            case "2":

                                View();
                                continue;

                            // Search
                            case "3":
                        Volunteer.NameSearch(volunteers);
                                continue;

                            // Stats
                            case "4":

                                Stats();
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
        static void Additions()
        {
            // non-conditional string returns
            string newName = NameRequest();
            string newRace = RaceRequest();
            string newEyeColor = EyeRequest();
            string newHairColor = HairRequest();
            string newTown = TownRequest();
            string newOrigin = OriginRequest();
            string newPrevVolunteering = PrevVolunteeringRequest();

            // non-conditional integer returns
            int newBirthYear = BirthYearRequest();
            int estimatedAge = (2026 - newBirthYear); // no method, calculation based on birth year
            int newHeight = HeightRequest();
            int newWeight = WeightRequest();
            
            int estimatedBMI = (newWeight / (newHeight * newHeight)); // based on height and weight NEED TO BE DOUBLE
            int newExpectedHours = ExpectedHourRequest();
            int newExperienceMonths = 0;
            int newVolunteerHours = 0;
            int newApplicantNumber = 1;
             

            // bool returns
            bool newSex = SexRequest();
            bool newPreviousVolunteering = PreviousVolunteeringRequest(); // Opens up new questions if true
            bool newAttendingClasses = AttendingClassesRequest();
            bool newReqAge = ReqAgeRequest(estimatedAge);
            bool newWorkOut = WorkOutRequest(); // Opens up new questions if true


           
            int newWeightLift = -1;
            bool newCarryCandidate = false;

            // workout condition returns
            if (newWorkOut == true)
            {
                newWeightLift = WeightLiftRequest();
                newCarryCandidate = CarryCandidateRequest(newWeightLift);
                
            }

            if (newPreviousVolunteering == true)
            {
                newExperienceMonths = ExperienceMonthsRequest();
                newVolunteerHours = VolunteerHoursRequest();
            }

            volunteers.Add(new Volunteer(newName, newRace, newEyeColor, newHairColor, newTown, newOrigin, newPrevVolunteering, newBirthYear, estimatedAge, newHeight, newExpectedHours, newExperienceMonths, newVolunteerHours, newWeight, newWeightLift, estimatedBMI, newApplicantNumber, newSex, newPreviousVolunteering, newWorkOut, newAttendingClasses, newReqAge, newCarryCandidate));
       

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
            static string PrevVolunteeringRequest() // CONDITIONAL - only asked if "yes" was answered to "Have you previously volunteered?"
            {
                Console.WriteLine("Please state the most recent volunteer program you've participated in: ");
                string prevVolunteeringInput = Console.ReadLine();
                return prevVolunteeringInput;
            }


            // NUMBER-BASED request methods
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
                Console.WriteLine("How many hours do you expect to volunteer? (per week): ");
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
            static bool SexRequest()
            {
                bool sexIsMale = false;

               
                bool loopTrue = true;
                while (loopTrue)
                {
                Console.WriteLine("What is your sex? (male/female): ");
                string sexStringInput = Console.ReadLine().ToLower();

                    if (sexStringInput == "male")
                    {
                        sexIsMale = true;
                        loopTrue = false;
                    }
                    else if (sexStringInput == "female")
                    {
                        sexIsMale = false;
                        loopTrue = false;
                    }
                    else
                    {
                        Console.WriteLine("Unknown answer. Try again.");
                    }
                }
                return sexIsMale;
            }
            static bool PreviousVolunteeringRequest()
            {
                Console.WriteLine("Have you previously volunteered? (yes/no): ");
                bool previousVolunteeringInput = YesNoVerification(Console.ReadLine());
                return previousVolunteeringInput;
            }
            static bool CarryCandidateRequest(int newWeightLift)
            {
                bool carryCandidateInput = false;

                if (newWeightLift >= 100)
                {
                    carryCandidateInput = true;
                }
                return carryCandidateInput;
            }
            static bool AttendingClassesRequest()
            {
                Console.WriteLine("Are you current attending any classes? (yes/no): ");
                bool attendingClassesInput = YesNoVerification(Console.ReadLine());
                return attendingClassesInput;
            }
            static bool ReqAgeRequest(int newAge)
            {
                bool over16 = false;
                if (newAge < 16)
                {
                    over16 = false;
                }
                else
                {
                    over16 = true;
                }
                return over16;
            }
            static bool WorkOutRequest()
            {
                Console.WriteLine("Do you work out? (yes/no): ");
                bool workOutInput = YesNoVerification (Console.ReadLine());
                return workOutInput;
            }
        }





        // View all logic
        static void View()
        {
            Volunteer.DisplayInfo(volunteers);
        }
        static void Stats()
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
            bool isTrue = false;

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
