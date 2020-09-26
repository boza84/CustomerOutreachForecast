using System.Web;
using System.Web.Mvc;

namespace CustomerOutreachForecast
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
