using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExampleService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleServiceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ExampleServiceController> _logger;

        public ExampleServiceController(ILogger<ExampleServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            var rng = new Random();
            return new List<string> { "one", "two" }
            .ToArray();
        }
    }
}
