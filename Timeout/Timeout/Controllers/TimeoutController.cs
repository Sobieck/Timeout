using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace Timeout.Controllers
{
    public class TimeoutController : ApiController
    {
        [Route("api/timeout/{numberOfSecondsToWait}")]
        public async Task<IHttpActionResult> Get(int numberOfSecondsToWait)
        {
            var timeToWait = TimeSpan.FromSeconds(numberOfSecondsToWait);

            await Task.Delay(timeToWait);

            return Ok();
        }
    }
}
