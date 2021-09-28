using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public Developer
    
    public class _DevTeamRepository
    {
        private List<Developer> DevTeamRepository = new List<Developer>();

        public int intialTotal { get; private set; }

        //create
        public void CreateNewDeveloper(Developer developers)
        {
            DevTeamRepository.Add(developers);
        }

        //read
        public List<Developer> GetDeveloperList()
        {
            return DevTeamRepository;
        }
        public bool UpdateExistingDevelopers(string orginalIdNumber, Developer newDeveloper)
        {
            //find the content
            Developer oldDeveloper = ViewByIdNumber(orginalIdNumber);

            //update the content
            if (oldDeveloper != null)
            {
                oldDeveloper.FirstName = newDeveloper.FirstName;
                oldDeveloper.LastName = newDeveloper.LastName;
                oldDeveloper.FullName = newDeveloper.FullName;
                oldDeveloper.IdNumber = newDeveloper.IdNumber;
                oldDeveloper.IsPluralsightAccessible = newDeveloper.IsPluralsightAccessible;

                return true;
            }
            else
            {
                return false;
            }

        }

        //delete
        public bool RemoveDeveloperFromList(string IdNumber)
        {
            Developer developers = ViewByIdNumber(IdNumber);

            if (developers == null)
            {
                return false;
            }
            int intialCount = DevTeamRepository.Count;
            DevTeamRepository.Remove(developers);

            if (intialCount > DevTeamRepository.Count)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        //Helper method
        public Developer ViewByIdNumber(string IdNumber)
        {
            foreach (Developer developers in DevTeamRepository)
            {
                if (developers.IdNumber == IdNumber)
                {
                    return developers;
                }

            }
            return null;
        }

       
        }
    }


