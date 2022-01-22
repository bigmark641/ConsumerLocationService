namespace ExampleService.Infrastructure.ServiceResponseModels
{
    class GeographyApiGetLocationByZipResponse
    {
        public GeographyApiGetLocationByZipResponse(int key, string zip, string state)
        {
            Key = key;
            Zip = zip;
            State = state;
        }

        public int Key { get; private set; }
        public string Zip { get; private set; }
        public string State { get; private set; }
    }
}
