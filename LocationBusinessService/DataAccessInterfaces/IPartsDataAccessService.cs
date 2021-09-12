using System.Collections.Generic;

namespace BusinessServices.DataAccessInterfaces
{
    public interface IPartsDataAccessService
    {

        /// <summary>
        /// Determines whether parts can be serviced in a mobile glass shop
        /// </summary>
        /// <param name="partNums"></param>
        /// <returns></returns>
        bool ArePartsServicableInMobileShop(IEnumerable<string> partNums);
    }
}
