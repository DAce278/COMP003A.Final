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
        public int bodyMass;
        public int ApplicantNum;

        public bool Sex;
        public bool PreviouslyVolunteered;
        public bool AttendingClasses;
        public bool Over16;

        public Volunteer(string name, string race, string eyeColor, string hairColor, string town, string areaOfOrigin, string previousVolunteerPosition, int birthYear, int age, int height, int expectedHours, int experienceMonths, int volunteerHours, int weight, int bodyMass, int applicantNum, bool sex, bool previouslyVolunteered, bool attendingClasses, bool over16)
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
            this.bodyMass = bodyMass;
            ApplicantNum = applicantNum;
            Sex = sex;
            PreviouslyVolunteered = previouslyVolunteered;
            AttendingClasses = attendingClasses;
            Over16 = over16;

     //       List<Volunteer> volunteers = new List<Volunteer>();
      //      volunteers.Add(volunteer1);
        }
          //  Volunteer volunteer1 = new("name", "race", "eye", "hair", "town", "origin", "prevvolunteerwork", 2020, 18, 60, 69, 47, 457, 57, 57, 57, true, true, true, true);

        
    }

    public class Physical
    {
        public int WeightLift;
        public bool PhysCandidate;

        public Physical(int weightLift, bool physCandidate)
        {
            WeightLift = weightLift;
            PhysCandidate = physCandidate;
        }

        public Physical()
        {
            Physical phys1 = new(234, true);
        }

    }
}
