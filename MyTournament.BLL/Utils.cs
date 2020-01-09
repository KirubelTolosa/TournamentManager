using MyTournament.BLL.DataModel;
using MyTournament.DAL.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
    public static class Utils
    {
        //create a sttic function that takes MemberBLDto object and returns MemberDADto
        public static MemberDADto ConvertMemberBLDtoDADto(MemberBLDto memberBLDto)
        {
            MemberDADto memberDADto = new MemberDADto
            {
                Id = memberBLDto.Id,
                Name = memberBLDto.Name,
                Position = memberBLDto.Position,
                Team_ID = memberBLDto.Team_Id
            };
            return memberDADto;            
        }

        public static MemberDADto ToDto(this MemberBLDto memberBLDto)
        {
            MemberDADto memberDADto = new MemberDADto
            {
                Id = memberBLDto.Id,
                Name = memberBLDto.Name,
                Position = memberBLDto.Position,
                Team_ID = memberBLDto.Team_Id
            };
            return memberDADto;
        }
        //create a static function that takes  MemberDADto object and returns MemberBLDto
    }
}
