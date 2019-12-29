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

        public static List<Team> teamDirectory = new List<Team>();
        public static List<Member> memberDirectory = new List<Member>();
               
        public static void AddTeams(string name, string id)
        {
            teamDirectory.Add(new Team()
                            {
                                Name = name,
                                Id = id
                            });   
            
        }
        public static void AddMember(string Id, string Name)
        {
            memberDirectory.Add(
                            new Member
                            {
                                Id = Id,
                                Name = Name
                            });
            
           
        }


    }
}
