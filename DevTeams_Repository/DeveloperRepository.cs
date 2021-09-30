using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Repository
{
    
         public class DeveloperRepository : DeveloperContent
    {
        //Field
        public readonly List<DeveloperContent> _contentDirectory = new List<DeveloperContent>();

        //Create
        public bool AddContentToDirectory(DeveloperContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read(GET)
        public List<DeveloperContent> GetContents()
        {
            return _contentDirectory;
        }
        //Get By IdNumber
        public DeveloperContent GetContentByIdNumber(string theIdNumberYouAreLookingFor)
        {
            foreach (DeveloperContent content in _contentDirectory)
            {
                if (content.IdNumber.ToLower() == theIdNumberYouAreLookingFor.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        //Update
        public bool UpdateExistingContent(DeveloperContent existingContent, DeveloperContent newContent)
        {
            if (existingContent != null)
            {
                existingContent.TeamName = newContent.TeamName;
                existingContent.FirstName = newContent.FirstName;
                existingContent.LastName = newContent.LastName;               
                existingContent.IsPluralsightAccessible = newContent.IsPluralsightAccessible;             
                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteContent(DeveloperContent existingContent)
        {
            bool result = _contentDirectory.Remove(existingContent);
            return result;
        }
    }
}




