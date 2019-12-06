using System.Web;
using System.Web.Mvc;
using COSC4351.AuthData;

namespace COSC4351
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new AuthAttribute());
        }
    }
}
