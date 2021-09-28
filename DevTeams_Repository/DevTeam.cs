using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DevTeam
    {
       
 
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IdNumber { get; set; }

        public string DevTeams { get; set; }

       

        private DevTeam(string firstName, string lastName, string idNumber, string devTeam)

            {
                FirstName = firstName;
                LastName = lastName;
                IdNumber = idNumber;
                DevTeams = devTeam;
                
            }
        }
    }

