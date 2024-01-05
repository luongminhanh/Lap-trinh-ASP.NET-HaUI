using System.Web;
using System.Web.Mvc;

namespace Bai4_ViDu_HKH
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
