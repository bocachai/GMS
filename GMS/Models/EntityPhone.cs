using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
{
    public class EntityPhone:BaseModel 
    {
        public Entity Entity { get; set; } = new Entity();
        public DetailType DetailType { get; set; } = new DetailType();
    }
}
