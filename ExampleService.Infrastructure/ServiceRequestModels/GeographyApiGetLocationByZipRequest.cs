using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleService.Infrastructure.ServiceRequestModels
{
    class GeographyApiGetLocationByZipRequest
    {
        public GeographyApiGetLocationByZipRequest(string zip)
        {
            Zip = zip;
        }

        public string Zip { get; private set; }
    }
}
