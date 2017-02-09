using System.Web;
using System.Web.Mvc;

namespace Rently
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());

            //add authorization for whole site by asking the members to login at the beginning of the action 
            // you cant even pass the home page
            filters.Add(new AuthorizeAttribute());

            //with this filter the application wont be available on http protocol only on https
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
