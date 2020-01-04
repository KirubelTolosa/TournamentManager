using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autofac;

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
            ContainerBuilder builder = new ContainerBuilder();
            BootStrap(builder);
            using (var container = builder.Build())
            {
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(container.Resolve<Home>());
            }      
        }


        public static void BootStrap(ContainerBuilder builder)
        {
           
            builder.RegisterType<Home>();
            builder.RegisterType<ViewMembers>().As<ViewMembers>();
            builder.RegisterType<ViewTeams>().As<ViewTeams>();
            builder.RegisterType<AddTeam>().As<AddTeam>();
            BLL.DIModule.RegisterServices(builder);   
        } 

        //public static List<Team> teamDirectory = new List<Team>();
        //public static List<Member> memberDirectory = new List<Member>();
               
        //public static void AddTeams(string name, string id)
        //{
        //    teamDirectory.Add(new Team()
        //                    {
        //                        Name = name,
        //                        Id = id
        //                    });   
            
        //}
        //public static void AddMember(string Id, string Name)
        //{
        //    memberDirectory.Add(
        //                    new Member
        //                    {
        //                        Id = Id,
        //                        Name = Name
        //                    });
            
           
        //}


    }
}
