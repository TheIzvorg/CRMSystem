//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRMSystem.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Type
    {
        public Type()
        {
            this.ProductTypes = new HashSet<ProductTypes>();
        }
    
        public int Id { get; set; }
        public string TypeName { get; set; }
    
        public virtual ICollection<ProductTypes> ProductTypes { get; set; }
    }
}
