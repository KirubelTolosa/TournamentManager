using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTournament.UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());
        }

        public static Team[] teamDirectory = new Team[100];

        public static int Counter = 0;
       
        public static void AddTeams(string name, string id)
        {
            
                var team = new Team();
                team.Name = name;
                team.Id = id;
                teamDirectory[Counter] = team;
                Counter++;
            
        }
    }
}
