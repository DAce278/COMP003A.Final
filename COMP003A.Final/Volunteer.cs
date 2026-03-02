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

        public Volunteer(string name, string race, string eyeColor, string hairColor, string town, string areaOfOrigin, string previousVolunteerPosition, int birthYear, int age, int height, int expectedHours, int experienceMonths, int volunteerHours, int weight, int weightLift, int bodyMass, int applicantNum, bool sex, bool previouslyVolunteered, bool carryCandidate, bool attendingClasses, bool overReqAge)
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


        }
    }
}
