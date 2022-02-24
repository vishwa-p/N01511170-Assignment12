using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01511170_Assignment2.Controllers
{
    public class J3ProblemController : ApiController
    {
        [HttpGet]
        [Route("api/J3Problem/{Number1}/{Number2}")]
        public int Get(int Number1, int Number2)
        {
            int count = 2;
            while (Number2 < Number1)
            {
                int temp1 = Number1;
                Number1 = Number2;
                Number2 = temp1 - Number2;
                count = count + 1;
            }
            return count;
        }
    }
}
