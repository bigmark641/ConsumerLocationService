using ExampleService.Domain.DomainModels;
using ExampleService.Domain.InfrastructureInterfaces;
using System;

namespace ExampleService.Domain
{

    public interface IExampleService
    {
        LocationModel GetLocation(int zipCode);
    }

    public class ExampleService : IExampleService
    {
        private readonly IExampleAdapter _exampleAdapter;

        public ExampleService(IExampleAdapter exampleAdapter)
        {
            _exampleAdapter = exampleAdapter;
        }

        public LocationModel GetLocation(int zipCode)
        {
            //Get location data
            var locationData = _exampleAdapter.GetLocation(zipCode);

            //Calculate state name
            string stateName =
                locationData.StateCode == "AK" ?
                    "Alaska" :
                locationData.StateCode == "AZ" ?
                    "Arizona" :
                locationData.StateCode == "AR" ?
                    "Arkansas" :
                locationData.StateCode == "CA" ?
                    "California" :
                //Else 
                    throw new NotImplementedException("TODO: Finish implementing this...");

            //Create location
            var location = new LocationModel(locationData.ZipCode, stateName);
            return location;
        }
    }
}
