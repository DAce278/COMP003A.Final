using System;
using System.Collections.Generic;
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
            Console.WriteLine("\nVolunteer Applicants: ");
            int i = 0;
            foreach (Volunteer volunteer in volunteers)
            {
                i++;
                Console.WriteLine(i + ". " + volunteer.Name + ": " + volunteer.Age + " years old - Residing in " + volunteer.Town + " - Applicant #:" + volunteer.ApplicantNum);

            }
        }
        static public void NameSearch(List<Volunteer> volunteers)
        {
            if (volunteers.Count > 0)
            {
                Console.Write("\nEnter the name of who you would like to search for: ");
                string nameSearch = "";
                nameSearch = Console.ReadLine();
            
                foreach (Volunteer volunteer in volunteers)
                {
                    if (volunteer.Name == nameSearch)
                    {
                        Console.WriteLine(volunteer.Name + ": " + volunteer.Age + " years old - Residing in " + volunteer.Town + "");
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNo users created.");
            }
        }

    }
}
