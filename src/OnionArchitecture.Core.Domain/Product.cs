namespace OnionArchitecture.Core.Domain
{
    public class Product
    {
        public virtual int ProductId { get; set; }
        public virtual string ProductName { get; set; }
        public virtual decimal UnitPrice { get; set; }        
        public virtual int CategoryId { get; set; }
    }
}
