using System.Web;
using System.Web.Mvc;

namespace Bai6_ViDu_HKH1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
