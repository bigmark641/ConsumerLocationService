namespace BusinessServices.DataAccessInterfaces
{
    public interface IZipDataAccessService
    {

        /// <summary>
        /// Determines whether a zip offers mobile service
        /// </summary>
        /// <param name="zip"></param>
        /// <returns></returns>
        bool IsMobileServiceAvailableForZip(int zip);
    }
}
