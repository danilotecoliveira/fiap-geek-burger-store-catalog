using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.StoreCatalog.Contract
{
    public class Restriction
    {
        public Guid RestrictionId { get; set; }
        public string Description { get; set; }
    }
}
