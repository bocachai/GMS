using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Models.Core;
using GMS.Models.Lookups;

namespace GMS.Models.Relations
{
    public class EntityName:BaseModel
    {
        #region Properties
        public Entity Entity { get; set; } = new Entity();
        public DetailSubType NameType { get; set; } = new DetailSubType();
        public string ResolvedName { get; set; }
        #endregion 
    }
}
