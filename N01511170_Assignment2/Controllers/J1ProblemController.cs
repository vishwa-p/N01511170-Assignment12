using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace N01511170_Assignment2.Controllers
{
    public class J1ProblemController : ApiController
    {
        [HttpGet]
        [Route("api/J1Problem/{speedLimit}/{recordedSpeed}")]
        public string Get(int speedLimit, int recordedSpeed)
        {
            if (recordedSpeed < speedLimit)
            {
                return "Congratulations, you are within the speed limit!";
            }
            else
            {
                int speedDifference = recordedSpeed - speedLimit;
                if (speedDifference >= 1 && speedDifference <= 20)
                {
                    return "You are speeding and your fine is $ 100";
                }
                else if (speedDifference >= 21 && speedDifference <= 30)
                {
                    return "You are speeding and your fine is $ 270";
                }
                else
                {
                    return "You are speeding and your fine is $500";
                }
            }
        }
    }
}
