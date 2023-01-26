using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;

namespace Module1.Controllers
{
    
    public class ChallengeController : ApiController
    {
        /// <summary>
        /// find the valume of the prism
        /// </summary>
        /// <param name="x"> width</param>
        /// <param name="y"> height</param>
        /// <param name="z"> length</param>
        /// <returns> when we enter the value of width , height and length
        /// like 2 , 2 and 4 repectively we get output as the total volume is 16</returns>
        [HttpGet]
        [Route("api/challenge/calculate/{x}/{y}/{z}")]
        public string calcuate(int x , int y, int z)
        {
            int volume = x * y * z;
            string message = "the total volume is" + " " +volume;
            return message;
        }

    }
}
