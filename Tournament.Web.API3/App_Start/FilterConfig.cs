﻿using System.Web;
using System.Web.Mvc;

namespace Tournament.Web.API3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
