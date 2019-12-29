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
   public class MemberBLService
    {
        public static List<MemberBLDto> GetAllMembers()
        {

            List<MemberDADto> daDtos = MemberDataRepository.GetAllMembers();

            List<MemberBLDto> blDtos = new List<MemberBLDto>();

            foreach (var daDto in daDtos)
            {
                MemberBLDto blDto = new MemberBLDto
                {
                    Id = daDto.Id,
                    Name = daDto.Name,
                    Position = daDto.Position,
                    Team_Id = daDto.Team_ID,
                };
                blDtos.Add(blDto);
            }

            return blDtos;
        }
 
        public static void AddMember(String member_Id, String memberName, String position, String team_Id)
        {
            
            MemberDataRepository.AddMember(member_Id, memberName, position, team_Id);
        }

        public static void AddMember(MemberBLDto memberBLDto)
        {
            MemberDADto memberDADto = new MemberDADto();
            memberDADto.Id = memberBLDto.Id;
            memberDADto.Name = memberBLDto.Name;
            memberDADto.Position = memberBLDto.Position;
            memberDADto.Team_ID = memberBLDto.Team_Id;
            MemberDataRepository.AddMember(memberDADto);

        }

        public static int CountMembers()
        {
            var count = MemberDataRepository.CountMembers();
            return count;
        }

    }
}
