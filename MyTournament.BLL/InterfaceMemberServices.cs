using MyTournament.BLL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
    interface IMemberServices
    {
        void AddMember(MemberBLDto memberBLDto);
        void AddMember(String member_Id, String memberName, String position, String team_Id);
        List<MemberBLDto> GetAllMembers();
    }
}
