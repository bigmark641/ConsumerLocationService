using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleService.Domain.InfrastructureModels
{
    public class LocationModel
    {
        public LocationModel(int zipCode, string stateCode)
        {
            ZipCode = zipCode;
            StateCode = stateCode;
        }

        public int ZipCode { get; private set; }
        public string StateCode { get; private set; }
    }
}
