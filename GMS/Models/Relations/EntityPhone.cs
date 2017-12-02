using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Models.Core;
using GMS.Models.Lookups;

namespace GMS.Models.Relations
{
    public class EntityPhone:BaseModel 
    {
        public Entity Entity { get; set; } = new Entity();
        public DetailType DetailType { get; set; } = new DetailType();
    }
}
