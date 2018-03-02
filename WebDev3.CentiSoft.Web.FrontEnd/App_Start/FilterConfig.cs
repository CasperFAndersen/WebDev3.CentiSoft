using System.Web;
using System.Web.Mvc;

namespace WebDev3.CentiSoft.Web.FrontEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
