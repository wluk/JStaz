using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService;

namespace UI.Web.App_Start
{
    public class LoadData
    {
        public static void LoadDataToDB()
        {
            SeedData.SeedDataStart();
        }
    }
}