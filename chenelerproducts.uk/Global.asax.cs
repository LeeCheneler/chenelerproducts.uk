using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace chenelerproducts.uk
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            MapRoutes();
        }


        private void MapRoutes()
        {
            RouteTable.Routes.MapRoute("Default",
                "{controller}/{action}",
                new { controller = "Home", action = "Index" });
        }
    }
}