using Microsoft.OData.Edm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.OData.Builder;

namespace OwinOdataTest
{
    class ODataConfigurator
    {
        public static IEdmModel GetEdmModel()
        {
            ODataModelBuilder builder = new ODataConventionModelBuilder();
            builder.EntitySet<Product>("Products");

            return builder.GetEdmModel();
        }
    }
}
