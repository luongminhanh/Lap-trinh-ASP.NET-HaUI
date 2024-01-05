using System.Web;
using System.Web.Mvc;

namespace Bai8_LinQ_EntityFrameWork
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
