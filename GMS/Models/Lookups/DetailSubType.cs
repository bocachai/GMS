using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models.Lookups
{
    public class DetailSubType:LookupTable 
    {
        #region Properties
        public bool IsDefault { get; set; }
        public DetailType DetailType { get; set; } = new DetailType();
        #endregion 

    }
}
