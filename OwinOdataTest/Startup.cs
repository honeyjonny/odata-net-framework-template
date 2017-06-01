using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.OData.Extensions;

namespace OwinOdataTest
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            // Configure Web API for self-host. 
            HttpConfiguration config = new HttpConfiguration();
            config.MapODataServiceRoute(
                routeName: "ODataRoute",
                routePrefix: "api/odata",
                model: ODataConfigurator.GetEdmModel());

            appBuilder.UseWebApi(config);
        }
    }
}
