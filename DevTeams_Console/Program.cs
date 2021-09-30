using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeams_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            DevTeamsConsole.DevTeamUI userInterface = new DevTeamsConsole.DevTeamUI();

            userInterface.Run();
            Console.ReadKey();
        }
    }
}


