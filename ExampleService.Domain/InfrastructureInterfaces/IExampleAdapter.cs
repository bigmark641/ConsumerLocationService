using ExampleService.Domain.InfrastructureModels;

namespace ExampleService.Domain.InfrastructureInterfaces
{
    public interface IExampleAdapter
    {

        LocationModel GetLocation(int zipCode);
    }
}
