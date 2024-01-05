using System.Web;
using System.Web.Mvc;

namespace LuongMinhAnh_Bai9GuiSV
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
