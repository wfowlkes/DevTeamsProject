using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public enum DevTeamRepository
         {
        DeveloperRepository = 1,
        DevTeamRepository,
           }

    public class Developer
    {
    
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string IdNumber { get; set; }

        public string DevTeam { get; set; }

        public bool IsPluralsightAccessible { get; set; }

       // public Team TypeOfTeam { get; set; }

        public Developer() { }
        
        public Developer(string firstName, string lastName, string FullName, string idNumber, string devTeam, bool PluralsightAccessible)

        {
            FirstName = firstName;
            LastName = lastName;
            FullName = "firstName" + "lastName";
            IdNumber = idNumber;
            DevTeam = devTeam;
            IsPluralsightAccessible = PluralsightAccessible;
           // TypeOfTeam = typeOfTeam;
        }


    }
}
