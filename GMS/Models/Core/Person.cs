using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GMS.Models.Lookups;
using GMS.Models.Relations;

namespace GMS.Models.Core
{
    public class Person:Entity
    {
        #region Properties
        public DateTime DateOfBirth { get; set; }
        public Country CountryOfBirth { get; set; }
        public Country CountryOfCitzenship { get; set; }
        public List<PersonName> PersonNames { get; set; }
        public List<EntityAddress > Adressess { get; set; }
        public List<EntityPhone> PhoneNumbers { get; set; }
        public List<EntityEmailAddress> EmailAdresses { get; set;}
        #endregion 
    }
}
