using Api.RequestDTOs;
using System;
using System.Collections.Generic;
using Xunit;

namespace ApiTests
{
    public class IsMobileServiceAvailableRequestTests
    {

        [Fact]
        public void Constructor_NullZip_InvalidArgumentException()
        {
            //Arrange
            int? zip = null;
            var partNums = new List<string>();

            //Act and assert
            Assert.Throws<ArgumentNullException>(() => new MobileServiceAvailabilityRequest(zip, partNums));
        }

        [Fact]
        public void Constructor_NullPartNums_InvalidArgumentException()
        {
            //Arrange
            int? zip = 0;
            IEnumerable<string> partNums = null;

            //Act and assert
            Assert.Throws<ArgumentNullException>(() => new MobileServiceAvailabilityRequest(zip, partNums));
        }

        [Fact]
        public void Constructor_SuppliedParameters_NoException()
        {
            //Arrange
            int? zip = 0;
            var partNums = new List<string>();

            //Act
            new MobileServiceAvailabilityRequest(zip, partNums);

            //Assert
            //No exception
        }
    }
}
