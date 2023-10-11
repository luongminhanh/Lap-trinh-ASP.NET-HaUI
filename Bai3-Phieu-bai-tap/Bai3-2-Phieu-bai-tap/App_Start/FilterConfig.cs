using System.Web;
using System.Web.Mvc;

namespace Bai3_2_Phieu_bai_tap
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
