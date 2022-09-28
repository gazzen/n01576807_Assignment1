using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// add Ten to the input number
        /// </summary>
        /// <param name="integer">Enter the interger value</param>
        /// <returns>Return the add</returns>
        ///<example>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 10
        /// GET api/AddTen/-9 -> 1
        ///</example>

        public int Get(int id)
        {
            int add = id + 10;
            return add;
        }


    }
}
