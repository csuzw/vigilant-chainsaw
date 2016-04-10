using System.Web.Http;
using System.Web.Http.Description;
using VigilantChainsaw.Services.Root;

namespace VigilantChainsaw.Application.Controllers
{
    [Route("/")]
    public class RootController : ApiController
    {
        private readonly IRootService _service;

        public RootController()
        {
            _service = new RootService();
        }

        [HttpGet()]
        [Route("")]
        [ResponseType(typeof(string))]
        public IHttpActionResult Get()
        {
            return Ok(_service.Get());
        }

        [HttpGet()]
        [Route("os")]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetOperatingSystem()
        {
            return Ok(_service.GetOperatingSystem());
        }

        [HttpGet()]
        [Route("version")]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetVersion()
        {
            return Ok(_service.GetVersion());
        }
    }
}