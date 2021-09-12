using BusinessServices.DataAccessInterfaces;
using System.Collections.Generic;

namespace BusinessServices
{

    public interface ILocationBusinessService
    {
        /// <summary>
        /// Determines whether mobile service is available
        /// </summary>
        /// <param name="zip"></param>
        /// <param name="partNums"></param>
        /// <returns></returns>
        bool IsMobileServiceAvailable(int zip, IEnumerable<string> partNums);
    }

    public class LocationBusinessService : ILocationBusinessService
    {

        private readonly IPartsDataAccessService _partsDataAccessService;
        private readonly IZipDataAccessService _zipDataAccessService;

        public LocationBusinessService(IPartsDataAccessService partsDataAccessService, IZipDataAccessService zipDataAccessService)
        {
            _partsDataAccessService = partsDataAccessService;
            _zipDataAccessService = zipDataAccessService;
        }

        public bool IsMobileServiceAvailable(int zip, IEnumerable<string> partNums)
        {
            return _zipDataAccessService.IsMobileServiceAvailableForZip(zip) 
                && _partsDataAccessService.ArePartsServicableInMobileShop(partNums);
        }
    }
}
