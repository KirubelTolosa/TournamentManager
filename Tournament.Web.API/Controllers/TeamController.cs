using MyTournament.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tournament.Web.API.Models;

namespace Tournament.Web.API.Controllers
{
    public class TeamController : ApiController
    {

        ITeamBLService teamBLService;

        public TeamController(ITeamBLService teamBLService)
        {
             this.teamBLService = teamBLService;
        }


        // GET: api/Teams
        public List<Team> Get()
        {
          var teams = teamBLService.GetAllTeams().Select(x=>new Team() { TeamId = x.Id, TeamName = x.Name }).ToList();
          return teams;
        }


        // GET: api/Teams
        public string GetTeamCount()
        {
            var teamCount = teamBLService.CountTeams().ToString();
            return teamCount;
        }

        // GET: api/Team/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Team
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Team/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {
        }
    }
}
