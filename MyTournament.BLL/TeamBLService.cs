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
    public class TeamBLService
    {
        public static List<TeamBLDto> GetAllTeams()
        {

            List<TeamDADto> daDtos = TeamDataRepository.GetAllTeams();

            List<TeamBLDto> blDtos = new List<TeamBLDto>();

            foreach(var daDto in daDtos)
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

        
    }
}
