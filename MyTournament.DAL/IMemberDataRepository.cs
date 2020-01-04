using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.DAL
{
  public interface IMemberDataRepository
  {
    List<MemberDADto> GetAllMembers();
    void AddMember(MemberDADto memberDADto);
    void AddMember(string member_Id, string memberName, string position, string team_Id);
    int CountMembers();
    int CountMembersInTeam(string Team_Id);
  }
}
