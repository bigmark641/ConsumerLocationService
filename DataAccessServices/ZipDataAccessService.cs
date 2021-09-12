using BusinessServices.DataAccessInterfaces;

namespace LocationDataAccessServices
{
    public class ZipDataAccessService : IZipDataAccessService
    {

        public bool IsMobileServiceAvailableForZip(int zip)
        {

            //TODO: Implement service call to ESL to retrieve location information
            return true;
        }
    }
}
