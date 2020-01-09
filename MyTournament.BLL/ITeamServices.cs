using MyTournament.BLL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
    public interface ITeamBLService
    {
        List<TeamBLDto> GetAllTeams();
        void AddTeam(String teamId, String teamName);
        List<string> GetTeamIds();
        void DeleteTeam(string team_Id);
        int CountTeams();
    }
}
