using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL.DataModel
{
    public class MemberBLDto
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public string Position { get; set; }
        public string Team_Id { get; set; }

    

        public MemberBLDto(string id, string name, string position, string team_id)
        {
            this.Id = id;
            this.Name = name;
            this.Position = position;
            this.Team_Id = team_id; 
        }
        public MemberBLDto()
        {
            
        }

    }
}
