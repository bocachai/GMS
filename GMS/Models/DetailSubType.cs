using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
{
    public class DetailSubType:BaseModel 
    {
        #region Properties
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public DetailType DetailType { get; set; } = new DetailType();
        #endregion 

    }
}
