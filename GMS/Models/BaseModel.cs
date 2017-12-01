using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
{
    public class BaseModel
    {
        #region Properties
        public int Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime DateLastUpdated { get; set; } = DateTime.Now;
        public int UserCreated { get; set; }
        public int UserLastUpdated { get; set; }
        #endregion 

    }
}
