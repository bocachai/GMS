﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Models.Lookups;

namespace GMS.Models.Relations
{
    public class PersonName: EntityName 
    {
        #region Properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string Surname { get; set; }
        public Title Title { get; set; } = new Title();
        #endregion 
    }
}
