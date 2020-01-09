using MyTournament.BLL.DataModel;
using MyTournament.BLL.DataModel.Exceptions;
using MyTournament.DAL;
using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
  
   public class MemberBLService : IMemberBLService
   {
        private IMemberDataRepository memberDataRepository;

       public MemberBLService()
        {
              memberDataRepository = new MemberDataRepository();
        }
        public MemberBLService(IMemberDataRepository memberDataRepository)
        {
            this.memberDataRepository = memberDataRepository;
        }
        public List<MemberBLDto> GetAllMembers()
        {
            List<MemberDADto> daDtos = memberDataRepository.GetAllMembers();

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

        public void AddMember(String member_Id, String memberName, String position, String team_Id)
        {
            var countOfMembers = CountMembersInTeam(team_Id);

            if (countOfMembers < 6)
            {
                memberDataRepository.AddMember(member_Id, memberName, position, team_Id);
            }
            else
            {                
                throw new AddMemberException(string.Format("The team with team ID {0} is full!", team_Id));
            }
        }

        public void AddMember(MemberBLDto memberBLDto)
        {
            MemberDADto memberDADto = new MemberDADto();
            memberDADto.Id = memberBLDto.Id;
            memberDADto.Name = memberBLDto.Name;
            memberDADto.Position = memberBLDto.Position;
            memberDADto.Team_ID = memberBLDto.Team_Id;
            var countOfMembers = CountMembersInTeam(memberDADto.Team_ID);

            if (countOfMembers < 6)
            {
                memberDataRepository.AddMember(memberDADto);
            }
            else
            {
                throw new AddMemberException(string.Format("The team with team ID {0} is already full!", memberDADto.Team_ID));
            }
        }
        public int CountMembers()
        {
            var count = memberDataRepository.CountMembers();
            return count;
        }
        private int CountMembersInTeam(string team_Id)
        {
            var count = memberDataRepository.CountMembersInTeam(team_Id);
            return count;
        }
       
    }
}
