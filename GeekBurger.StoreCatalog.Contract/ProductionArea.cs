using System;

namespace GeekBurger.StoreCatalog.Contract
{
    public class ProductionArea
    {
        public Guid ProductionAreaId { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string[] Restrictions { get; set; }
    }
}