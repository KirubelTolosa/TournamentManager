using Autofac;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace Tournament.Web.API
{

  public class AutofacWebapiConfig
  {

    public static IContainer Container;

    public static void Initialize(HttpConfiguration config)
    {
      RegisterServices(config, new ContainerBuilder());
    }


    private static IContainer RegisterServices(HttpConfiguration config, ContainerBuilder builder)
    {
      MyTournament.BLL.DIModule.RegisterServices(builder);
      builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
      Container = builder.Build();
      config.DependencyResolver = new AutofacWebApiDependencyResolver(Container);

      return Container;
    }
  }
}
