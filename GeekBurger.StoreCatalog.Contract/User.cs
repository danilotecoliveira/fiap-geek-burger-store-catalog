using System;

namespace GeekBurger.StoreCatalog.Contract
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string[] Restrictions { get; set; }
    }
}
