using BusinessServices.DataAccessInterfaces;
using System.Collections.Generic;

namespace LocationDataAccessServices
{
    public class PartsDataAccessService : IPartsDataAccessService
    {

        public bool ArePartsServicableInMobileShop(IEnumerable<string> partNums)
        {

            //TODO: Implement service call to some other API to retrieve part information
            return true;
        }
    }
}
