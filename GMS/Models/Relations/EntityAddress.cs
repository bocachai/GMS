using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Models.Core;
using GMS.Models.Lookups;

namespace GMS.Models.Relations
{
    public class EntityAddress:BaseModel
    {
        #region Properties
        public Entity Entity { get; set; } = new Entity();
        public DetailSubType AddressType { get; set; } = new DetailSubType();
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostalCode { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        #endregion 
    }
}
