﻿using System.Web;
using System.Web.Mvc;

namespace zad_4_CRUD_in_MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
