using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
{
    public class Entity: BaseModel 
    {
        #region Properties
        public bool IsSubscribedToNewsLetter { get; set; }
        public EntityType EntityType { get; set; } = new EntityType();
        public List<EntityName> Names { get; set; } = new List<EntityName>();
        public List<EntityAddress> Addressess { get; set; } = new List<EntityAddress>();
        public List<EntityPhone> Phones { get; set; } = new List<EntityPhone>();
        public List<EntityEmailAddress> EmailAddressess { get; set; } = new List<EntityEmailAddress>();
        #endregion 
    }
}
