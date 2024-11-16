using System.Web;
using System.Web.Mvc;

namespace WebApp_mvc_Dbfirst
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
