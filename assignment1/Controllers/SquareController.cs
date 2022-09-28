using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
  
    public class SquareController : ApiController
    {
        /// <summary>
        /// Multiply the input number
        /// </summary>
        /// <param name="integer">Enther the number</param>
        /// <returns></returns>
        ///<example>
        /// GET api/Square/2 -> 4
        /// GET api/Square/-2 -> 4
        /// GET api/Square/10 -> 100
        ///</example>
        public int Get(int id)
        {
            int sq = id * id;
            return sq;
        }

    }
}
