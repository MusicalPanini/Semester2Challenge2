﻿using System.Web;
using System.Web.Mvc;

namespace Sem2Challenge2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
