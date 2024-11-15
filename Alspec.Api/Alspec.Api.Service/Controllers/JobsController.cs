using Alspec.Api.Service.Helpers;
using Alspec.Api.Service.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Alspec.Api.Service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private static List<Job> Jobs = new List<Job>();
        private SeedDataHelper seedDataHelper;

        public JobsController(SeedDataHelper seedHelper)
        {
            this.seedDataHelper = seedHelper;
        }

        [HttpGet]
        public IActionResult GetJobs()
        {   
            return Ok(this.seedDataHelper.GetJob());
        }

        [HttpPost]
        public IActionResult AddJob([FromBody] Job job)
        {
            job.Id = "1";
            Jobs.Add(job);
            return Ok(job);
        }
    }
}
