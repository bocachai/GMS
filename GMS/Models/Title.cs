using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMS.Models
{
    public class Title: BaseModel 
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
