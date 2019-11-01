using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.DAL
{
    public class TeamDataRepository
    {
        public static void AddTeam(string teamName, string teamId)
        {
            //To Do 
            //Connect to database and add a team
        }

        //public static Team GetTeam(string teamId)
        //{
        //    //get team by Id
        //}

        public static List<TeamDADto> GetAllTeams()
        {
            //go to the database 
            List<TeamDADto> items = new List<TeamDADto>();
            items.AddRange(new[]{ new TeamDADto()
                                    {
                                        Name = "chelsea" , Id = "1001"
                                    },
                                      new TeamDADto()
                                        {
                                            Name = "Manchester",
                                            Id = "1002"
                                        }
                });
            return items;
        }


    }
}
