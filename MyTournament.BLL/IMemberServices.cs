using MyTournament.BLL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
    public interface IMemberBLService
    {
        void AddMember(MemberBLDto memberBLDto);
        void AddMember(String member_Id, String memberName, String position, String team_Id);
        List<MemberBLDto> GetAllMembers();
        int CountMembers();
    }
}
