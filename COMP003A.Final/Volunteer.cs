using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace COMP003A.Final
{
    public class Volunteer
    {
        public string Name;
        public string Race;
        public string EyeColor;
        public string HairColor;
        public string Town;
        public string AreaOfOrigin;
        public string PreviousVolunteerPosition;

        public int BirthYear;
        public int Age;
        public int Height;
        public int ExpectedHours;
        public int ExperienceMonths;
        public int VolunteerHours;
        public int Weight;
        public int WeightLift;
        public int bodyMass;
        public int ApplicantNum;

        public bool Sex;
        public bool PreviouslyVolunteered;
        public bool CarryCandidate;
        public bool AttendingClasses;
        public bool OverReqAge;
        public bool WorkOut;

        public Volunteer(string name, string race, string eyeColor, string hairColor, string town, string areaOfOrigin, string previousVolunteerPosition, int birthYear, int age, int height, int expectedHours, int experienceMonths, int volunteerHours, int weight, int weightLift, int bodyMass, int applicantNum, bool sex, bool previouslyVolunteered, bool workOut, bool attendingClasses, bool overReqAge, bool carryCandidate)
        {
            Name = name;
            Race = race;
            EyeColor = eyeColor;
            HairColor = hairColor;
            Town = town;
            AreaOfOrigin = areaOfOrigin;
            PreviousVolunteerPosition = previousVolunteerPosition;
            BirthYear = birthYear;
            Age = age;
            Height = height;
            ExpectedHours = expectedHours;
            ExperienceMonths = experienceMonths;
            VolunteerHours = volunteerHours;
            Weight = weight;
            WeightLift = weightLift;
            this.bodyMass = bodyMass;
            ApplicantNum = applicantNum;
            Sex = sex;
            PreviouslyVolunteered = previouslyVolunteered;
            CarryCandidate = carryCandidate;
            AttendingClasses = attendingClasses;
            OverReqAge = overReqAge;
            WorkOut = workOut;


        }
        static public void DisplayInfo(List<Volunteer> volunteers)
        {
            if (volunteers.Count > 0)
            {
                Console.WriteLine("\nVolunteer Applicants: ");
                int i = 0;
                foreach (Volunteer volunteer in volunteers)
                {
                    i++;
                    Console.WriteLine(i + ". " + volunteer.Name + ": " + volunteer.Age + " years old - Residing in " + volunteer.Town + " - Applicant #:" + volunteer.ApplicantNum);

                }
            }
            else
            {
                Console.WriteLine("\nNo users found");
            }
        }
        static public void NameSearch(List<Volunteer> volunteers)
        {
            if (volunteers.Count > 0)
            {
                Console.Write("\nEnter the name of who you would like to search for: ");
                string nameSearch = "";
                nameSearch = Console.ReadLine();

                Console.WriteLine("\nDisplaying profiles with the name " + nameSearch + ":\n");
            
                foreach (Volunteer volunteer in volunteers)
                {
                    string sexString = SexConversion(volunteer); 
                    if (volunteer.Name == nameSearch)
                    {
                        Console.WriteLine(volunteer.Name + ": " + volunteer.Age + " years old; Born in " + volunteer.BirthYear + " - Residing in " + volunteer.Town + "; Place of Origin - " + volunteer.AreaOfOrigin + "; Attending classes? - " + volunteer.AttendingClasses + "; Applicant #:" + volunteer.ApplicantNum);
                        Console.WriteLine("Physical Attributes: Race - " + volunteer.Race + "; Sex - " + sexString + "; Eye Color - " + volunteer.EyeColor + "; Hair Color - " + volunteer.HairColor + "; Height - " + volunteer.Height + "; Weight - " + volunteer.Weight + ", BMI - " + volunteer.bodyMass);
                            Console.Write("Volunteering Information: Expected hours - " + volunteer.ExpectedHours + "; Previously volunteered? - " + volunteer.PreviouslyVolunteered);
                        
                        // Conditionally shown stats based on previous volunteering
                        if (volunteer.PreviouslyVolunteered == true)
                        {
                            Console.WriteLine("; Previous Volunteering Role - " + volunteer.PreviousVolunteerPosition + "; Volunteer Hours - " + volunteer.VolunteerHours + "; Total Months Spent Volunteering - " + volunteer.ExperienceMonths);
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        Console.Write("Physical capabilities: Workout - " + volunteer.WorkOut);

                        // Condittionally shown stats based on previous volunteering
                        if (volunteer.WorkOut == true)
                        {
                            Console.WriteLine("; Bench Press - " + volunteer.WeightLift + "; Carry Candidate? - " + volunteer.CarryCandidate);
                        }
                        else
                        {
                            Console.WriteLine("; Rest Unknown"); 
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNo users found.");
            }
        }

        // Method to display Male/Female instead of True/False
        static public string SexConversion(Volunteer volunteer)
        {
            string sexString;
            if (volunteer.Sex == true)
            {
                sexString = "Male";
            }
            else
            {
                sexString = "Female";
            }
            return sexString;

        }

        static public void Statistics(List<Volunteer> volunteers)
        {
            
            AgeStats(volunteers);
            ExpecetedHoursStats(volunteers);
        }

        static public void AgeStats(List<Volunteer> volunteers)
        {
            int count = 0;
            int ageSum = 0;
            int ageAvg = 0;
            if (ageSum > 0 || count > 0)
            {
                ageSum = 0;
                count = 0;
            }
            foreach (Volunteer volunteer in volunteers)
            {
                ageSum += volunteers[count].Age;
                count++;
            }
            ageAvg = ageSum / count;
            Console.WriteLine("\nAverage age: " + ageAvg);
        }

        static public void ExpecetedHoursStats(List<Volunteer> volunteers)
        {
            int count = 0;
            int hourSum = 0;
            int hourAvg = 0;
            if (hourSum  > 0 || count > 0)
            {
                hourSum = 0;
                count = 0;
            }
            foreach (Volunteer volunteer in volunteers)
            {
                hourSum += volunteers[count].ExpectedHours;
                count++;
            }
            hourAvg = hourSum / count;
            Console.WriteLine("\nAverage expected hours of volunteers: " + hourAvg);
        }
    }
}
