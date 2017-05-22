using System.Web;
using System.Web.Mvc;

namespace LSTest_MVCCount
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
