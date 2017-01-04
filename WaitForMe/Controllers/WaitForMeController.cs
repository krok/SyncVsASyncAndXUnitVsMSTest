using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;

namespace WaitForMe.Controllers
{
    public class WaitForMeController : ApiController
    {
        // GET api/name
        [SwaggerOperation("Wait for me")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public async Task Get(string name, [FromUri] int seconds = 1)
        {
            await Task.Delay(seconds*1000);
        }
    }
}