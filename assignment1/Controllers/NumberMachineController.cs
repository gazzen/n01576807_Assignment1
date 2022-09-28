using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {

        /// <summary>
        /// Stating the number entered
        /// </summary>
        /// <param name="id">Enter the number</param>
        /// <returns>
        /// you have found the greeting
        /// </returns>
        /// <example>
        /// GET: api/NumberMachine/10-> "This is number 10!"
        /// GET: api/NumberMachine/-5-> "This is negative number -5!"
        /// GET: api/NumberMachine/30-> "This is number 30!"
        /// </example>


        public string Get(int id)
        {
            if (id == 10)
            {
                return "This is number 10!";
            }

            else if (id == -5)
            {
                return "This is negative number -5!";
            }

            else
            {
                return "This is number 30!";
            }
        }
    }
}
