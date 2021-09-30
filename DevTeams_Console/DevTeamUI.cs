
using DevTeams_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamsConsole
{
    public class DevTeamUI

    {

        public DeveloperRepository _repo = new DeveloperRepository();
        private DeveloperRepository _devContent = new DeveloperRepository();
        private DevTeamRepository _devTeamContent = new DevTeamRepository();
        public DeveloperContent updatedContent = new DeveloperContent();

        public void Run()
        {
            SeedData();

            RunMenu();
        }

        private void RunMenu()
        {


            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                Console.WriteLine("Enter the number of your selection:\n" +
                    "1. Create New Content\n" +
                    "2. Show All Content\n " +
                    "3. View Content By IdNumber\n" +
                    "4. Update Content\n" +
                    "5. View All Teams\n" +
                    "6. RemoveContentFromRepository\n" +
                    "7. Add Developer To DevTeam\n" +
                    "8. Pluaralsight Accessible\n" +
                    "9. Delete DevTeam\n" +
                    "10. Add DevTeam\n" +
                    "0. Exit"
                    );

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateNewDeveloper();
                        break;
                    case "2":
                        ShowAllDevelopers();
                        break;
                    case "3":
                        ShowDeveloperIdNumber();
                        break;
                    case "4":
                        UpdateDeveloper();
                        break;
                    case "5":
                        ViewAllTeams();
                        break;
                    case "6":
                        RemoveDeveloperFromRepository();
                        break;
                    case "7":
                        AddDeveloperToDevTeam();
                        break;
                    case "8":
                        IsPluralsightAccessible();
                        break;
                    case "9":
                        DeleteDevTeam();
                        break;
                    case "10":
                        AddDevTeam();
                        break;
                    case "0":
                        Console.WriteLine("Thank you GoodBye");
                        isRunning = false;
                        //Exit
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number between 0 and 10.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;

                }
            }
        }

        //Creating Content
        private void CreateNewDeveloper()
        {
            Console.Clear();

            DeveloperContent content = new DeveloperContent();

            //IdNumber
            Console.WriteLine("Please enter a IdNumber:");
            content.IdNumber = Console.ReadLine();

            //First Name
            Console.WriteLine("Please enter a first name:");
            content.FirstName = Console.ReadLine();

            //last Name
            Console.WriteLine("Please enter a last name:");
            content.LastName = Console.ReadLine();

            Console.WriteLine("Please enter a TeamName name:");
            content.TeamName = Console.ReadLine();

            Console.WriteLine("Please enter Y or N:");
            content.IsPluralsightAccessible = IsPluralsightAccessible();

            _devContent.AddContentToDirectory(content);
        }

        //Getting all Content
        private void ShowAllDevelopers()
        {
            //Clean slate to work from
            Console.Clear();

            List<DeveloperContent> listOfContent = _devContent.GetContents();

            foreach (DeveloperContent content in listOfContent)
            {
                //Using helper method
                DisplayContent(content);
            }

            PressAnyKeyToContinue();
        }

        //Getting Specific Content(By IdNumber)
        private void ShowDeveloperIdNumber()
        {
            Console.Clear();

            Console.WriteLine("What IdNumber are you looking for?");
            string IdNumber = Console.ReadLine();

            DeveloperContent content = _devContent.GetContentByIdNumber(IdNumber);
            //Verify that content is in our repository

            if (content != null)
            {
                //Using helper method
                DisplayContent(content);
            }
            else
            {
                Console.WriteLine("Unfortunatley we don't have that IdNumber");
            }

            PressAnyKeyToContinue();

        }

        //Update Content
        private void UpdateDeveloper()
        {
            Console.Clear();

            Console.WriteLine("What is the IdNumber of the content you want to update:");
            string targetIdNumber = Console.ReadLine();

            DeveloperContent tarGetDeveloperContent = _devContent.GetContentByIdNumber(targetIdNumber);

            if (tarGetDeveloperContent == null)
            {
                Console.WriteLine("We are not able to find that content");
                PressAnyKeyToContinue();
                return;
            }

            DeveloperContent updatedContent = new DeveloperContent();

            //IdNumber
            Console.WriteLine($"Original IdNumber: {tarGetDeveloperContent.IdNumber}\n" +
                $"Please enter a new IdNumber:");
            updatedContent.IdNumber = Console.ReadLine();

            Console.WriteLine($"Original First Name: {tarGetDeveloperContent.FirstName}");
            Console.WriteLine("Please enter a new First Name:");
            updatedContent.FirstName = Console.ReadLine();

            Console.WriteLine($"Original Last Name: {tarGetDeveloperContent.LastName}");
            Console.WriteLine("Please enter a new last name:");
            updatedContent.LastName = Console.ReadLine();

            Console.WriteLine($"Original PluralsightAccessible: {tarGetDeveloperContent.IsPluralsightAccessible}\n" +
                $"What is the new Pluralsight Status:");
            updatedContent.IsPluralsightAccessible = IsPluralsightAccessible();

            Console.WriteLine($"Original TeamName: {tarGetDeveloperContent.TeamName}\n" +
                $"What is the new Team Name:");
            updatedContent.TeamName = Console.ReadLine();

            if (_devContent.UpdateExistingContent(tarGetDeveloperContent, updatedContent))
            {
                Console.WriteLine("Update successful");
            }
            else
            {
                Console.WriteLine("Update Failed");
            }

            PressAnyKeyToContinue();
        }


        //Deleting Content
        private void RemoveDeveloperFromRepository()
        {
            Console.Clear();


            List<DeveloperContent> contentList = _devContent.GetContents();

            int index = 1;

            foreach (DeveloperContent content in contentList)
            {
                Console.WriteLine($"{index}. {content.IdNumber}");
                index++;
            }

            Console.WriteLine("What IdNumber would you like to remove.");
            int targetIdNumberId = int.Parse(Console.ReadLine());
            int targetIndex = targetIdNumberId - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                DeveloperContent targetDeveloperContent = contentList[targetIndex];

                if (_devContent.DeleteContent(targetDeveloperContent))
                {
                    Console.WriteLine($"{targetDeveloperContent.IdNumber} was successfully deleted");
                }
                else
                {
                    Console.WriteLine("Please try again, something went wrong!");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
            }

            PressAnyKeyToContinue();
        }
        private void AddDeveloperToDevTeam()
        {
            Console.Clear();
            Console.WriteLine("Please enter Id Number you want to add to DevTeam:");
            string targetIdNumber = Console.ReadLine();

           // DevTeamContent targetContent = _repo.AddContentToDirectory(targetIdNumber);
        }
        public bool IsPluralsightAccessible()
        {


            Console.WriteLine("Is Pluralsight Accessible?");
            string isPluralsightAccessible = Console.ReadLine().ToLower();

            if (isPluralsightAccessible == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddDevTeam(DevTeamContent existingContent, DevTeamContent newContent)
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
        public void DeleteDevTeam()
        {
            Console.Clear();

            List<DevTeamContent> contentList = _devTeamContent.GetContents();

            int index = 1;

            foreach (DevTeamContent content1 in contentList)
            {
                Console.WriteLine($"{index}. {content1.TeamName}");
                index++;
            }

            Console.WriteLine("What DevTeam would you like to remove.");
            int TeamName = int.Parse(Console.ReadLine());
            int targetIndex = TeamName - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                DevTeamContent targetDevTeamContent = contentList[targetIndex];

                if (_devTeamContent.DeleteContent(targetDevTeamContent))
                {
                    Console.WriteLine($"{targetDevTeamContent.TeamName} was successfully deleted");
                }
                else
                {
                    Console.WriteLine("Please try again, something went wrong!");
                }
            }
            else
            {
                Console.WriteLine("That is not a valid selection.");
            }
        }
        private void AddDevTeam()
        {
            Console.WriteLine("Add DevTeam");
            Console.Clear();

            DevTeamContent content1 = new DevTeamContent();

            Console.WriteLine("Please enter a Team name:");
            content1.TeamName = Console.ReadLine();

            Console.WriteLine("Please enter a Team Number:");
            content1.TeamNumber = Console.ReadLine();


            Console.WriteLine("Please enter the TeamMember you want :");
            content1.TeamMember = Console.ReadLine();


            _devTeamContent.AddContentToDirectory(content1);
        }
        public void ViewAllTeams()
        {
         
             
        }

        //Helper Methods
        private void DisplayContent(DeveloperContent content)
        {
            Console.WriteLine(
                    $"IdNumber: {content.IdNumber}\n" +
                    $"FirstName: {content.FirstName}\n" +
                    $"LastName: {content.LastName}\n" +
                    $"IsPluralsightAccessible: {content.IsPluralsightAccessible}");




        }

        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private void SeedData()
        {
            DeveloperContent jonSmith = new DeveloperContent("1234", "Jon", "Smith", "", true);
            DeveloperContent johnSmyth = new DeveloperContent("2314", "John", "Smyth", "", false);
            DeveloperContent johnathonSmithson = new DeveloperContent("4321", "Johnathon", "Smithson", "", true);

            _devContent.AddContentToDirectory(jonSmith);
            _devContent.AddContentToDirectory(johnSmyth);
            _devContent.AddContentToDirectory(johnathonSmithson);
        }
    }
}



