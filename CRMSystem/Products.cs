//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRMSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public Products()
        {
            this.ProductOrder = new HashSet<ProductOrder>();
            this.ProductTypes = new HashSet<ProductTypes>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal PriceChange { get; set; }
        public int Count { get; set; }
    
        public virtual ICollection<ProductOrder> ProductOrder { get; set; }
        public virtual ICollection<ProductTypes> ProductTypes { get; set; }
    }
}
