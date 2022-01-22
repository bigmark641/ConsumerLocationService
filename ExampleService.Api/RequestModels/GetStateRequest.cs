namespace ExampleService.Api.RequestModels
{
    public class GetStateRequest
    {
        GetStateRequest(int zipCode)
        {
            ZipCode = zipCode;
        }

        public int ZipCode { get; private set; }
    }
}
