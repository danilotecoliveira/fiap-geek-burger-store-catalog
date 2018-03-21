using System;

namespace GeekBurger.StoreCatalog.Contract
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; }
    }
}
