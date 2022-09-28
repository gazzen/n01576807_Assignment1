using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class HostingCostController : ApiController
    {

        /// <summary>
        /// Enter the fortnight value
        /// </summary>
        /// <param name="id">Enter the fortnight value</param>
        /// <returns>
        /// Return the total cost
        /// </returns>
        /// <example>
        /// GET:api/HostingCost/0-> $6.22
        /// GET:api/HostingCost/14-> $12.43
        /// GET:api/HostingCost/15-> $12.43
        /// GET:api/HostingCost/21-> $12.43
        /// GET:api/HostingCost/28-> $18.64
        /// </example>
        public string Get(double id)
        {
            double FN_cost=5.50;
            double Hst_tax = 0.13 * 5.50;
            double total_FN_cost;

            if (id >=0 && id <14)
            {
                total_FN_cost = FN_cost + Hst_tax;
                return "The total cost will be " + "$"+total_FN_cost;
            }

            else if (id >=14 && id<=21)
            {
                total_FN_cost = 2 * (FN_cost + Hst_tax);
                return "The total cost will be "+"$"+total_FN_cost;
            }

            else
            {
                total_FN_cost = 3 * (FN_cost + Hst_tax);
                return "The total cost will be " + "$"+total_FN_cost;
            }
        }
    }
}
