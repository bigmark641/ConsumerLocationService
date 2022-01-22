using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleService.Domain.DomainModels
{
    public class LocationModel
    {

        public LocationModel(int zipCode, string stateName)
        {
            ZipCode = zipCode;
            StateName = stateName;
        }

        public int ZipCode { get; private set; }

        public string StateName { get; private set; }
    }
}
