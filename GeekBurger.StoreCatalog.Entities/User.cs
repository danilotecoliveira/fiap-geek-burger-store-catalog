using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.StoreCatalog.Entities
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public IEnumerable<Restriction> Restrictions { get; set; }
    }
}
