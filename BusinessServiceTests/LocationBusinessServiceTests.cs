using BusinessServices;
using BusinessServices.DataAccessInterfaces;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BusinessServiceTests
{
    public class LocationBusinessServiceTests
    {

        [Fact]
        public void IsMobileServiceAvailable_NotAvailableForZip_False()
        {
            //Arrange
            var service = CreateService(isMobileServiceAvailableForZip: false);

            //Act
            var returnValue = service.IsMobileServiceAvailable(0, null);

            //Assert
            Assert.False(returnValue); //Mobile service is NOT available if NOT available for zip
        }

        [Fact]
        public void IsMobileServiceAvailable_PartsNotServicableInMobileShop_False()
        {
            //Arrange
            var service = CreateService(arePartsServicableInMobileShop: false);

            //Act
            var returnValue = service.IsMobileServiceAvailable(0, null);

            //Assert
            Assert.False(returnValue); //Mobile service is NOT available when parts are NOT servicable in a mobile shop
        }

        [Fact]
        public void IsMobileServiceAvailable_PartsAreServicableAndAvailableForZip_True()
        {
            //Arrange
            var service = CreateService(isMobileServiceAvailableForZip: true, arePartsServicableInMobileShop: true);

            //Act
            var returnValue = service.IsMobileServiceAvailable(0, null);

            //Assert
            Assert.True(returnValue); //Mobile service IS available if parts ARE servicable mobily and it IS available for zip
        }

        private LocationBusinessService CreateService(bool isMobileServiceAvailableForZip = true, bool arePartsServicableInMobileShop = true)
        {
            //Setup IZipDataAccessService mock
            var zipDataAccessServiceMock = new Mock<IZipDataAccessService>();
            zipDataAccessServiceMock.Setup(x => x.IsMobileServiceAvailableForZip(It.IsAny<int>())).Returns(isMobileServiceAvailableForZip);

            //Setup IPartsDataAccessService mock
            var partsDataAccessServiceMock = new Mock<IPartsDataAccessService>();
            partsDataAccessServiceMock.Setup(x => x.ArePartsServicableInMobileShop(It.IsAny<IEnumerable<string>>())).Returns(arePartsServicableInMobileShop);

            //Construct service
            return new LocationBusinessService(partsDataAccessServiceMock.Object, zipDataAccessServiceMock.Object);
        }
    }
}
