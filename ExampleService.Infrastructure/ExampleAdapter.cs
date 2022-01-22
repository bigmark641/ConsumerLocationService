using ExampleService.Domain.InfrastructureInterfaces;
using ExampleService.Domain.InfrastructureModels;
using ExampleService.Infrastructure.ServiceRequestModels;
using ExampleService.Infrastructure.ServiceResponseModels;

namespace ExampleService.Infrastructure
{
    public class ExampleAdapter : IExampleAdapter
    {
   
        public LocationModel GetLocation(int zipCode)
        {
            //Build request
            var zipCodeAsString = zipCode.ToString();
            var request = new GeographyApiGetLocationByZipRequest(zipCodeAsString);

            //Get response from external api (or database, file system, or wherever)
            var response = InvokeGeographyApiGetLocationByZip(request);

            //Create location
            var zipCodeFromResponse = int.Parse(response.Zip);
            var stateCodeFromResponse = response.State;
            return new LocationModel(zipCodeFromResponse, stateCodeFromResponse);
        }

        private GeographyApiGetLocationByZipResponse InvokeGeographyApiGetLocationByZip(GeographyApiGetLocationByZipRequest request)
        {
            //This method probably wouldn't exist in our solution.
            //It's just representing an external service call.
            return new GeographyApiGetLocationByZipResponse(12345, request.Zip, "CA");
        }
    }
}
