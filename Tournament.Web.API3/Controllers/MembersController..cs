using MyTournament.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tournament.Web.API3.Models;

namespace Tournament.Web.API3.Controllers
{
    public class MembersController : ApiController
    {
        private ITeamBLService teamBLService;

        public MembersController(ITeamBLService teamBLService) {
            this.teamBLService = teamBLService;
        }
        // GET api/values
        /// <summary>
        /// api returns list members
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TeamModel> Get()
        {
            return teamBLService.GetAllTeams().Select(x => new TeamModel() { TeamId = x.Id, TeamName = x.Name }).ToList();
           // return new string[] { "kirubel", "solomon" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
