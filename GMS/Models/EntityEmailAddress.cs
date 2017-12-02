using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
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
