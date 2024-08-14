using System.Web;
using System.Web.Mvc;

namespace thanhtri_2121110007
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
