using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
{
    public class EntityName
    {
        #region Properties
        public Entity Entity { get; set; } = new Entity();
        public DetailSubType NameType { get; set; } = new DetailSubType();
        public string ResolvedName { get; set; }
        #endregion 
    }
}
