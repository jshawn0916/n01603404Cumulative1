﻿using System.Web;
using System.Web.Mvc;

namespace n01603404Cumulative1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
