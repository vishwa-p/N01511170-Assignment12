using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01511170_Assignment2.Controllers
{
    public class J2ProblemController : ApiController
    {
        [HttpGet]
        [Route("api/J2Problem/{a}/{b}/{c}/{d}")]
        public string Get(int a, int b, int c, int d)
        {
            if (a < b && b < c && c < d)
            {
                return "Fish Rising";
            }
            else if (a > b && b > c && c > d)
            {
                return "Fish Diving";
            }
            else if (a == b && b == c && c == d)
            {
                return "Fish At Constant Depth";
            }
            else
            {
                return "No Fish.";
            }
        }
    }
}
