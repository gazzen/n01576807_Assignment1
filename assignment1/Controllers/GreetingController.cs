using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace assignment1.Controllers
{
    public class GreetingController : ApiController

    {

        /// <summary>
        /// Displays Greeting message
        /// </summary>
        /// .................For COMMAND PROMPT POST method.............
        /// curl -d "" localhost:59282/api/Greeting/
        /// ..................................................................
        /// <returns>
        /// you have found the POST method
        /// </returns>
        /// POST: api/Greeting -> "Hello World!"
        public string Post()
        {
            return "Hello World!";

        }

        /// <summary>
        /// Display the greeting message
        /// </summary>
        /// <param name="id">Enter the number</param>
        /// <returns>
        /// you have found the greeting
        /// </returns>
        /// <example>
        /// GET: api/Greeting/3-> "Greetings to 3 people!"
        /// GET: api/Greeting/6-> "Greetings to 6 people!"
        /// GET: api/Greeting/0-> "Greetings to 0 people!"
        /// </example>


        public string Get(int id)
        {
            if (id == 3)
            {
                return "Greetings to 3 people!";
            }

            else if (id == 6)
            {
                return "Greetings to 6 people!";
            }

            else
            {
                return "Greetings to 0 people!";
            }
        }
    }
}
