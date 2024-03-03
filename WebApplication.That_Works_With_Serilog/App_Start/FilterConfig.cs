using System.Web;
using System.Web.Mvc;

namespace WebApplication.That_Works_With_Serilog
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
