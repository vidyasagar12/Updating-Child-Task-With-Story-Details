using System.Web;
using System.Web.Mvc;

namespace Updating_Child_Task_With_Story_Details_WebAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
