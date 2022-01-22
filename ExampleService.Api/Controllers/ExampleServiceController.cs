using ExampleService.Api.RequestModels;
using ExampleService.Api.ResponseModels;
using ExampleService.Domain;
using Microsoft.AspNetCore.Mvc;

namespace ExampleService.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExampleServiceController : ControllerBase
    {
        private readonly IExampleService _exampleService;

        public ExampleServiceController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet]
        public GetStateResponse GetState(GetStateRequest request)
        {
            //Get location
            var location = _exampleService.GetLocation(request.ZipCode);

            //Create response
            var response = new GetStateResponse(location.StateName);
            return response;
        }
    }
}
