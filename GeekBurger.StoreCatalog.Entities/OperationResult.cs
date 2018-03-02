using System;

namespace GeekBurger.StoreCatalog.Entities
{
    public class OperationResult<T>
    {
        public DateTime Date { get { return DateTime.Now; } }
        public bool Success { get; set; } = false;
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
