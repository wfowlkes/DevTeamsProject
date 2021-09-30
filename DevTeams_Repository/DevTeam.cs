using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DevTeamContent
    {
        public DevTeamContent() { }

        public DevTeamContent(string teamMember, string teamName, string teamNumber)
        {
            TeamMember = teamMember;
            TeamName = teamName;
            TeamNumber = teamNumber;
            
        }
        public string TeamMember { get; set; }

        public string TeamName { get; set; }

        public string TeamNumber { get; set; }
        
        



        public enum teamName
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




