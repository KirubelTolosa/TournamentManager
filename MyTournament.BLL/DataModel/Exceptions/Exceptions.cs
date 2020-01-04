using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL.DataModel.Exceptions
{
  public class AddTeamException : Exception
  {
    public AddTeamException(string custommessage) : base(custommessage)
    {
    }
  }
  public class DeleteTeamException : Exception
  {
    public DeleteTeamException(string message)
       : base(message)
    {
    }
  }

  public class AddMemberException : Exception
  {
    public AddMemberException(string message)
       : base(message)
    {
    }
  }
}
