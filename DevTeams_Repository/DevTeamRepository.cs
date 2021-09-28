using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    class DevTeams_Repository
    {
        public class DevTeamsRepository
        {
            private List<Developer> _DeveloperRepository = new List<Developer>();

            public int intialTotal { get; private set; }

            //create
            public void CreateNewDeveloper(Developer developers)
            {
                _DeveloperRepository.Add(developers);
            }

            //read
            public List<Developer> GetDeveloperList()
            {
                return _DeveloperRepository;
            }
            public bool UpdateExistingDevelopers(string orginalIdNumber, Developer newDeveloper)
            {
                //find the content
                Developer oldDeveloper = ViewByIdumber(orginalIdNumber);

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
            public bool RemoveDeveloperFromList(string idNumber)
            {
                Developer developers = ViewByIdumber(idNumber);

                if (developers == null)
                {
                    return false;
                }
                int intialCount = _DeveloperRepository.Count;
                _DeveloperRepository.Remove(developers);

                if (intialCount > _DeveloperRepository.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            //Helper method
            public Developer ViewByIdumber(string IdNumber)
            {
                foreach (Developer developers in _DeveloperRepository)
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
}

