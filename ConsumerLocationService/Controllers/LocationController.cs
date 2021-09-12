using Api.RequestDTOs;
using BusinessServices;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {

        private readonly ILocationBusinessService _locationService;

        public LocationController(ILocationBusinessService locationService)
        {
            _locationService = locationService;
        }

        /// <summary>
        /// Determines whether mobile service should be offered 
        /// </summary>
        /// <param name="zip"></param>
        /// <returns></returns>
        [HttpPost("IsMobileServiceAvailable")]
        public ActionResult<bool> IsMobileServiceAvailable([FromBody]MobileServiceAvailabilityRequest request)
        {
            return _locationService.IsMobileServiceAvailable(request.Zip, request.PartNums);
        }
    }
}
