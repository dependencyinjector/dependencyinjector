using System.Web;
using System.Web.Mvc;

namespace DependencyInjector
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            Contract.IsNotNull(filters, "filers");
            filters.Add(new HandleErrorAttribute());
        }
    }
}
