using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTournament.BLL
{
  public static class DIModule
  {
    public static void RegisterServices(ContainerBuilder builder)
    {
      builder.RegisterType<TeamBLService>().As<ITeamBLService>();
      builder.RegisterType<MemberBLService>().As<MemberBLService>();

      DAL.DIModule.RegisterServices(builder);
    }
  }
}
