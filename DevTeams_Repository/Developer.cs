using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DeveloperContent
    {
        public DeveloperContent() { }

        public DeveloperContent(string idNumber, string firstName, string lastName, string teamName, bool pluralsightAccessible)
        {
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            TeamName = teamName;
            IsPluralsightAccessible = pluralsightAccessible;
        }
        public string IdNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsPluralsightAccessible { get; set; }

        public string TeamName { get; set; }











        public enum DevTeam
        {
            DevTeam = 1,
            DevTeamA,
            DevTeamB,
            DevTeamC,
            DevTeamD,
            DevTeamE,
        }

    }
}


