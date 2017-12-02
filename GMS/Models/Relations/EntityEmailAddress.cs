using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Models.Lookups;
using GMS.Models.Core;

namespace GMS.Models.Relations
{
    public class EntityEmailAddress:BaseModel
    {
        #region Properties
        public Entity Entity { get; set; } = new Entity();
        public DetailSubType AddressType { get; set; } = new DetailSubType();
        public string EmailAddress { get; set; }
        #endregion 
    }
}
