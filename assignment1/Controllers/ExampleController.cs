using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    //recieve a number
    //send back the same number

    // GET/api/example/{id} ->id
    //.................................
    //GET /api/example/4 ->4
    //GET /api/example/7 ->7
    //GET /api/example/-10 ->-10


    public class ExampleController : ApiController
    {
        /// <summary>
        /// subtracts 5 from the input number
        /// </summary>
        /// .................For COMMAND PROMPT GET method.............
        /// curl localhost:59282/api/example/
        /// ..................................................................
        /// <param name="id">The input number</param>
        /// <returns>Returns the input number minus five</returns>
        /// <example>
        /// GET api/example/6 ->1
        /// GET api/example/0 ->-5
        ///</example>
        public int Get(int id)
        {
            int calulation = id - 5;
            return calulation;

        }

        /// <summary>
        /// Displays s welcome message
        /// </summary>
        /// .................For COMMAND PROMPT POST method.............
        /// curl -d "" localhost:59282/api/example/
        /// ..................................................................
        /// <returns>
        /// you have found the POST method
        /// </returns>
        /// POST api/example -> "You have found POST method"

        public string Post()
        {
            return "You have found POST method ";

        }

        //POST /api/example/{id}
        //curl -d "" localhost:XXXX/api/example
       public int Post(int id)
        {
            return 6;
        }




    }
}
