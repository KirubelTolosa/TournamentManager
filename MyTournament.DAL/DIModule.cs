using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.DAL
{
  public static class DIModule
  {
    public static void RegisterServices(ContainerBuilder builder)
    {
      builder.RegisterType<TeamDataRepository>().As<ITeamDataRepository>();
      builder.RegisterType<MemberDataRepository>().As<IMemberDataRepository>();
    }
  }
}
