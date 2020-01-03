using MyTournament.BLL.DataModel;
using MyTournament.DAL;
using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
    public class TeamBLService : ITeamServices
    {
        public List<TeamBLDto> GetAllTeams()
        {

            List<TeamDADto> daDtos = TeamDataRepository.GetAllTeams();

            List<TeamBLDto> blDtos = new List<TeamBLDto>();

            foreach (var daDto in daDtos)
            {
                TeamBLDto blDto = new TeamBLDto
                {
                    Name = daDto.Name,
                    Id = daDto.Id
                };
                blDtos.Add(blDto);
            }

            return blDtos;
        }


        public void AddTeam(String teamId, String teamName)
        {
            var countTeams = TeamDataRepository.CountTeams();
            if (countTeams < 9)
            {
                TeamDataRepository.AddTeam(teamId, teamName);
            }
            else
            {
                throw new AddTeamException("The tournament is full. Delete a team or create a new tournamet!!");
            }
        }
        public static int CountTeams()
        {
            var teamcount = TeamDataRepository.CountTeams();
            return teamcount;
        }

        public List<string> GetTeamIds()
        {
            var teamIds = TeamDataRepository.GetTeamIds();
            return teamIds;
        }

        public void DeleteTeam(string team_Id)
        {
            try
            {
                TeamDataRepository.DeleteTeam(team_Id);
            }
            catch
            {
                throw new DeleteTeamException(string.Format("The team has data that depend on it! Delete those first!"));
            }
        }

        public class AddTeamException : Exception
        {
            public AddTeamException(string custommessage) : base(custommessage)
            {
            }
        }
        public class DeleteTeamException : Exception
        {
            public DeleteTeamException(string message)
               : base(message)
            {
            }
        }
    }
}
