using System.Web;
using System.Web.Mvc;

namespace ValeriaTapiaFuscoFriendAPI1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
