using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    public class DevTeamRepository : DevTeamContent
    {
        
   
        
        //Field
        public readonly List<DevTeamContent> _contentDirectory = new List<DevTeamContent>();

        //Create
        public bool AddContentToDirectory(DevTeamContent content1)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content1);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read(GET)
        public List<DevTeamContent> GetContents()
        {
            return _contentDirectory;
        }
        //Get By IdNumber
        public DevTeamContent GetContentByIdNumber(string theIdNumberYouAreLookingFor)
        {
            foreach (DevTeamContent content in _contentDirectory)
            {
                if (content.TeamNumber.ToLower() == theIdNumberYouAreLookingFor.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingDevTeam(DevTeamContent existingContent, DevTeamContent newContent)
        {
            if (existingContent != null)
            {
                existingContent.TeamMember = newContent.TeamMember;
                existingContent.TeamName = newContent.TeamName;
                existingContent.TeamNumber = newContent.TeamNumber;               
             
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteContent(DevTeamContent existingContent)
        {
            bool result = _contentDirectory.Remove(existingContent);
            return result;
        }
    }
}
