using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.DAL
{
    public interface ITeamDataRepository
    {
      void AddTeam(string teamId, string teamName);
      List<DataModel.TeamDADto> GetAllTeams();
      int CountTeams();
      List<string> GetTeamIds();
      void DeleteTeam(string teamId);   
  }

}
