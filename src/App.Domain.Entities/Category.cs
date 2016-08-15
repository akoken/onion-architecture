using System.Collections.Generic;

namespace App.Domain.Entities
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string CategoryName { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
