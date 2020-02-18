using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inhouse_Products.Models
{
    public enum ProductStatus
    {
        Ordered,
        ReceivedOnTime,
        ReceivedEarly,
        ReceivedLate,
        NotReceived,
        Sold
    }
}
