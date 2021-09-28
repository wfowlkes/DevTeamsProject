using DevTeams_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Console

{
    public Developer 
        


    public class DevTeamUi
    {

       

        //method that runs/starts the application
        public void Run()
        {
            SeedData();

            Menu();
        }



        //Menu
        public void Menu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();

                //display options to the user
                Console.WriteLine("Hello Please select a menu option from below:\n" +
                    "1. Create New Developer\n" +
                    "2. View All Developers\n " +
                    "3. View Developers By IdNumber\n" +
                    "4. Update Delete Existing Developers\n" +
                    "5. View All Teams\n" +
                    "6. Add Developer To DevTeam\n" +
                    "7. Is Pluaralsight Accessible\n" +
                    "8. Update_Delete Existing DevTeams\n" +
                    "9. Add DevTeam\n" +
                    "0. Exit");

                //Get the user's input
                string userInput = Console.ReadLine();

                //evaluate the user's input and act accordingly
                switch (userInput)
                {
                    case "1":
                        //create new developer
                        CreateNewDeveloper();
                        break;
                    case "2":
                        //view all developers
                        ViewAllDevelopers();
                        break;
                    case "3":
                        ViewByIdNumber();
                        //view developer by IdentificationNumber
                        break;
                    case "4":
                        UpdateExistingDevelopers();
                        //update existing developers
                        break;
                    case "5":
                        ViewAllTeams();
                        //delete existing developers
                        break;

                    case "6":
                        AddDeveloperToDevTeam();
                        break;

                    case "7":
                        IsPluralsightAccessible();
                        break;

                    case "8":
                        UpdateDeleteExistingDevTeams();
                        break;

                    case "9":
                        AddDevTeam();
                        break;

                    case "0":
                        //exit
                        Console.WriteLine("Thank you GoodBye");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                break;
            }
        }

        private void AddDevTeam()
        {
            
        }

        private void UpdateDeleteExistingDevTeams()
        {
            
        }

        private void IsPluralsightAccessible()
        {
            
        }

        private void AddDeveloperToDevTeam()
        {
            
        }

        private void ViewAllTeams()
        {
            
        }

        private void UpdateExistingDevelopers()
        {
            
        }

        private void ViewAllDevelopers()
        {
            
        }

        private void ViewByIdNumber()
        {
            
        }


        //create new Developer
        public void CreateNewDeveloper()
        {
            Developer newDeveloper = new Developer();

            //FirstName
            Console.WriteLine("Enter the first name for the developer:");
            newDeveloper.FirstName = Console.ReadLine();

            //LastName
            Console.WriteLine("Enter the last name for the developer:");
            newDeveloper.LastName = Console.ReadLine();
            //FullName
            Console.WriteLine("Enter the full name for the developer:");
            newDeveloper.FullName = Console.ReadLine();
            //IdentificationNumber

            Console.WriteLine("Enter the id number for the developer:");
            newDeveloper.IdNumber = Convert.ToString(Console.ReadLine());

            _DeveloperRepository developerRepository = new _DeveloperRepository(newDeveloper);

            developerRepository.CreateNewDeveloper(developerRepository);


             void ViewByIdNumber(string idNumber)
            {
                Console.Clear();

                Console.WriteLine("Please enter Identification Number");
                string IdNumber = Console.ReadLine();

                Developer developers = developerRepository.ViewByIdNumber(idNumber);

                if (developers != null)

                {
                    ViewByIdNumber(idNumber);

                }
                else
                {
                    Console.WriteLine("Unfortunatley that is not a vaild Identification Number");
                    Console.ReadKey();
                }

                //update developers
                void UpdateExistingDevelopers()
                {
                    Console.Clear();
                    Console.WriteLine("Which Developer do you want to update:");
                    string targetDeveloper = Console.ReadLine();

                    Developer targetDevelopers = developerRepository.GetDeveloperByFullName(targetDeveloper);

                    if (targetDevelopers == null)
                    {
                        Console.WriteLine("That Developer is not in the system");
                        PressAnyKeyToContinue();
                        return;
                    }
                    Developer updatedDevelopers = new Developer();

                    //First Name
                    Console.WriteLine($"Original firstName: { targetDevelopers.FirstName}\n" +
                        $"Please enter new firstName:");
                    updatedDevelopers.FirstName = Console.ReadLine();

                    //Last Name
                    Console.WriteLine($"Original lastName: { targetDevelopers.LastName}\n" +
                        $"Please enter new lastName:");
                    updatedDevelopers.LastName = Console.ReadLine();

                    //Full Name
                    Console.WriteLine($"Original fullName: { targetDevelopers.FullName}\n" +
                        $"Please enter new fullName:");
                    updatedDevelopers.FullName = Console.ReadLine();

                    //IdentificationNumber
                    Console.WriteLine($"Original IdNumber: { targetDevelopers.IdNumber}\n" +
                        $"Please enter new IdNumber:");
                    updatedDevelopers.IdNumber = Console.ReadLine();

                    //Active Team
                    Console.WriteLine($"Original Team: { targetDevelopers.DevTeam}\n" +
                        $"Please enter new DevTeam:");
                    updatedDevelopers.DevTeam = Console.ReadLine();

                    //Active Pluarlsight
                    Console.WriteLine($"Original Pluaralsight Status: { targetDevelopers.IsPluralsightAccessible}\n" +
                        $"Please enter new status:");
                    updatedDevelopers.IsPluralsightAccessible = Console.ReadLine("");

                    if (developerRepository.UpdateExistingDevelopers(targetDeveloper, updatedDevelopers))
                    {
                        Console.WriteLine("Update Successful");
                    }
                    else
                    {
                        Console.WriteLine("Update Failed");
                    }

                    void RemoveDeveloperFromRepository()
                    {
                        Console.Clear();

                        List<Developer> DeveloperRepository = developerRepository(developers);

                        int index = 1;

                        foreach (Developer developer in DeveloperRepository)
                        {
                            Console.WriteLine($"{index} {developers.IdNumber}");
                            index++;
                        }
                        Console.WriteLine("What Developer would you like to remove.");
                        int targetIdNumber = int.Parse(Console.ReadLine());
                        int targetIndex = targetIdNumber - 1;

                        if (targetIndex >= 0 && targetIndex < DeveloperRepository.Count)

                        {
                            Developer targetRemoveDeveloperFromList = DeveloperRepository[targetIndex];

                            if (developerRepository.RemoveDeveloperFromList(targetDeveloper))
                            {
                                Console.WriteLine($"{targetDevelopers.IdNumber} was successfully deleted");
                            }
                            else
                            {
                                Console.WriteLine("Id Number not found!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That is not a vaild Id Number.");
                        }
                        PressAnyKeyToContinue();


                        Console.WriteLine("Add Developer To DevTeam");


                        //IsPluaralSightAccessible
                        Console.WriteLine("Is Pluralsight Accessible?");
                        string isPluralsightAccessiblestring = Console.ReadLine().ToLower();

                        if (isPluralsightAccessiblestring == "y")
                        {
                            newDeveloper.IsPluralsightAccessible = true;
                        }
                        else
                        {
                            newDeveloper.IsPluralsightAccessible = false;
                        }

                        Console.WriteLine("Update Delete Existing DevTeams");

                        Console.WriteLine("Add DevTeam");

                        //Add developer
                        Console.WriteLine("Click to Update or Add to Repository:/n" +
                            "1. DeveloperRepository:\n" +
                            "2. DevTeamRepository");
                        string Update_AddToRepositoryAsString = Console.ReadLine();
                        int Update_AddToRepositoryAsInt = int.Parse(Update_AddToRepositoryAsString);
                        new Developer.AddDeveloper() = new DevTeam (newDeveloper);

                        DeveloperRepository.AddDeveloper(newDeveloper);
                    }

                    //view current developers that are saved

                    void ViewAllDevelopers(Developer DeveloperRepository)
                    {
                        Console.WriteLine(
                           $"First Name: {developers.FirstName}\n" +
                           $"Last Name: {developers.LastName}\n" +
                           $"Full Name: {developers.FullName}\n" +
                           $"Id Number: {developers.IdNumber}\n" +
                           $"Pluralsight Accessible: {developers.IsPluralsightAccessible}\n\n");

                    }

                    //update eisting developers
                    void UpdateExistingDeveloper()
                    {

                    }
                    //delete existing developers
                    void DeleteExistingDeveloper()
                    {

                    }
                    void AddDevTeam()
                    {
                        
                    }

                    void UpdateDeleteExistingDevTeams()
                    {
                        
                    }

                    void AddDeveloperToDevTeam()
                    {
                        
                    }

                    void ViewAllTeams()
                    {
                       
                    }
                }

                void ViewAllDevelopers(List<Developer> DeveloperRepository)
                {

                    Console.Clear();
                    List<Developer> _DeveloperRepository = developerRepository.GetDeveloperList();

                    foreach (Developer DevTeams in DeveloperRepository)
                    {
                        ViewAllDevelopers(DeveloperRepository);
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }

                void PressAnyKeyToContinue()
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
            }
        }

        private void ViewAllDevelopers(List<Developer> developerRepository)
        {
           
        }

        public static void SeedData()
        {
            Developer devTeamOne = new DevTeamOne ("John", "Smith", 100000000, devTeamOne: );
            Developer devTeamTwo = new DevTeamTwo ("Jon", "Smyth", 110000011, devTeamTwo: );
            Developer devTeamThree = new DevTeamThree("Johnathon", "Smithson", 122000022, devTeamThree: );
        }
    }
}

        
 




    

