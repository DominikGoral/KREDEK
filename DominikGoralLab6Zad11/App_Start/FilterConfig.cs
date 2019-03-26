using System.Web;
using System.Web.Mvc;

namespace DominikGoralLab6Zad11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
