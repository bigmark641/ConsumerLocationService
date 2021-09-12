using System;
using System.Collections.Generic;

namespace Api.RequestDTOs
{
    public class MobileServiceAvailabilityRequest
    {
        public readonly int Zip;
        public readonly IEnumerable<string> PartNums;

        public MobileServiceAvailabilityRequest(int? zip, IEnumerable<string> partNums)
        {
            //Ensure required fields are supplied
            Zip = zip.HasValue ? zip.Value : throw new ArgumentNullException(nameof(zip));
            PartNums = partNums ?? throw new ArgumentNullException(nameof(partNums));
        }
    }
}
