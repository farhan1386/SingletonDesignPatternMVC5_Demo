﻿using System.Web;
using System.Web.Mvc;

namespace SingletonDesignPatternMVC5_Demo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
