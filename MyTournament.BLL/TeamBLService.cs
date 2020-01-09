using MyTournament.BLL.DataModel;
using MyTournament.DAL;
using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyTournament.BLL.DataModel.Exceptions;

namespace MyTournament.BLL
{
    public class TeamBLService : ITeamBLService
    {
       private ITeamDataRepository teamDataRepository;

        public TeamBLService()
        {
            this.teamDataRepository = new TeamDataRepository();
        }
        public TeamBLService(ITeamDataRepository teamDataRepository)
         {
              this.teamDataRepository = teamDataRepository;
         }
        
        public List<TeamBLDto> GetAllTeams()
        {         
            List<TeamDADto> daDtos = teamDataRepository.GetAllTeams();
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
            var countTeams = teamDataRepository.CountTeams();
            if (countTeams < 9)
            {
                teamDataRepository.AddTeam(teamId, teamName);
            }
            else
            {
                throw new AddTeamException("The tournament is full. Delete a team or create a new tournamet!!");
            }
        }
        public int CountTeams()
        {
            var teamcount = teamDataRepository.CountTeams();
            return teamcount;
        }

        public List<string> GetTeamIds()
        {
            var teamIds = teamDataRepository.GetTeamIds();
            return teamIds;
        }

        public void DeleteTeam(string team_Id)
        {
            try
            {
                teamDataRepository.DeleteTeam(team_Id);
            }
            catch
            {
                throw new DeleteTeamException(string.Format("The team has data that depend on it! Delete those first!"));
            }
        }

       
    }
}
