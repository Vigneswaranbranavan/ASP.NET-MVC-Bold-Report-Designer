﻿using System.Web;
using System.Web.Mvc;

namespace ASP.NET_MVC_Reporting_Report_Designer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
