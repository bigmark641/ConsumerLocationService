namespace ExampleService.Api.ResponseModels
{
    public class GetStateResponse
    {
        public GetStateResponse(string stateName)
        {
            StateName = stateName;
        }

        public string StateName { get; private set; }
    }
}
