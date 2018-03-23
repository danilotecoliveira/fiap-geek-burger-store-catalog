using System;
using System.Collections.Generic;
using System.Text;

namespace GeekBurger.StoreCatalog.Contract
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public IEnumerable<string> Restrictions { get; set; }
    }
}
